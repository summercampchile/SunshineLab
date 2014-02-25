using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;
using Microsoft.WindowsAzure.MobileServices;

namespace _247
{
    public partial class Registar : PhoneApplicationPage
    {
		// Using a stream reference to upload the image to blob storage.
        Stream imageStream = null;

        // MobileServiceCollectionView implements ICollectionView (useful for databinding to lists) and 
        // is integrated with your Mobile Service to make it easy to bind your data to the ListView
        private MobileServiceCollection<Users, Users> usuario;

        private IMobileServiceTable<Users> tablaUsuarios = App.MobileService.GetTable<Users>();
		
        public Registar()
        {
            try
            {
                InitializeComponent();
            }
            catch (IOException e)
            {
                MessageBox.Show( "a" +  e);
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a
        /// marca de agua y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "Nombre") 
            {
                txtNombre.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtNombre.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de
        /// agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == string.Empty) 
            {
                txtNombre.Text = "Nombre";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtNombre.Foreground = brush1;
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a marca de agua 
        /// y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCiudad_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtCiudad.Text == "Ciudad")
            {
                txtCiudad.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtCiudad.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una 
        /// marca de agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCiudad_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtCiudad.Text == string.Empty)
            {
                txtCiudad.Text = "Ciudad";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtCiudad.Foreground = brush1;
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a 
        /// marca de agua y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtApellido.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca 
        /// de agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.Text = "Apellido";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtApellido.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua 
        /// correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRegion_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegion.Text == string.Empty)
            {
                txtRegion.Text = "Region";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtRegion.Foreground = brush1;
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y 
        /// cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRegion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegion.Text == "Region")
            {
                txtRegion.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtRegion.Foreground = brush1;
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtMail.Text == "Mail")
            {
                txtMail.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtMail.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMail.Text == string.Empty)
            {
                txtMail.Text = "Mail";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtMail.Foreground = brush1;
            }
        }

        /// <summary>
        /// al hacerse click al password box y borra el texto del textbox que esta atras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length == 0)
                txtPassword.Text = string.Empty;
        }

        /// <summary>
        /// volver a colocar el nombre del Tag al textbox que esta abajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length == 0)
                txtPassword.Text = txtPassword.Tag.ToString();
        }

        /// <summary>
        /// al hacerse click al password box y borra el texto del textbox que esta atras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox2.Password.Length == 0)
                txtConfirmarPassword.Text = string.Empty;
        }

        /// <summary>
        /// volver a colocar el nombre del Tag al textbox que esta abajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox2.Password.Length == 0)
                txtConfirmarPassword.Text = txtConfirmarPassword.Tag.ToString();
        }

        /// <summary>
        /// Sube los datos del usuario a Azure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //extraer los datos del formulario
            var usuario = new Users{
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                ciudad = txtCiudad.Text,
                region = txtRegion.Text,
                mail = txtMail.Text,
                password = passwordBox.Password
            };
            //enviar a la base de datos si es qque se puede
            if (ConfirmPassword())
            {
                InsertUser(usuario);
                //Manda de vuelta a donde pertenece
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("El campo de contraseña no coincide con su pass");
                passwordBox.Password = "";
                passwordBox2.Password = "";
                txtPassword.Text = txtPassword.Tag.ToString();
                txtConfirmarPassword.Text = txtConfirmarPassword.Tag.ToString();
            }
        }

        /// <summary>
        /// Inserta un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">el usuario a insertar</param>
        private async void InsertUser(Users usuario) 
        {
            try
            {
                await tablaUsuarios.InsertAsync(usuario);
                string ho = usuario.Id;
                MessageBox.Show(ho);
                MessageBox.Show("Registrado");
            }
            catch (MobileServiceInvalidOperationException e) 
            {
                MessageBox.Show(e.Message, "No se pude conectar, no se registro", MessageBoxButton.OK);
            }
        }

        /// <summary>
        /// valida que a password sea igual que el confirm pass
        /// </summary>
        /// <returns></returns>
        private bool ConfirmPassword() 
        {
            return (passwordBox.Password.Equals(passwordBox2.Password) & (passwordBox.Password.Length > 0));
        }

        /// <summary>
        /// colocar foto para los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubirFoto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhotoChooserTask photo = new PhotoChooserTask();
            photo.ShowCamera = true;
            photo.Show();
            photo.Completed += photo_Completed;
        }

        /// <summary>
        /// Coocar foto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void photo_Completed(object sender, PhotoResult e)
        {
            if (e != null && e.ChosenPhoto != null)
            {
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                ImgPerfil.Source = image;

                imageStream = e.ChosenPhoto;
            }
        }
    }
}