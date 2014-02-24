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

namespace _247
{
    public partial class Registar : PhoneApplicationPage
    {
		// Using a stream reference to upload the image to blob storage.
        Stream imageStream = null;
		
        public Registar()
        {
            InitializeComponent();
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Informacion.xaml", UriKind.Relative));
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhotoChooserTask photo = new PhotoChooserTask();
            photo.ShowCamera = true;

            photo.Show();

            photo.Completed += photo_Completed;
        }

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

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("/Registrado.xaml", UriKind.Relative));
        }


        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
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
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
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
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
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
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
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
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
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
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
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
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
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
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
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
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtPassword.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtPassword.Foreground = brush1;
            }
        }

        /// <summary>
        /// cuando se hace click en el campo, hace desaparecer a marca de agua y cambia el color de texto a negro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConfirmarPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtConfirmarPassword.Text == "Confirmar Password")
            {
                txtConfirmarPassword.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtConfirmarPassword.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando el usuario saca el mouse de campo, se coloca una marca de agua correspondiente a ese lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConfirmarPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtConfirmarPassword.Text == string.Empty)
            {
                txtConfirmarPassword.Text = "Confirmar Password";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtConfirmarPassword.Foreground = brush1;
            }
        }
    }
}