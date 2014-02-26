using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.IO;
using Microsoft.WindowsAzure.MobileServices;
using _247.Resources;

namespace _247
{
    public partial class LoginPage : PhoneApplicationPage
    {
        
        private MobileServiceCollection<Users, Users> usuario;
        private IMobileServiceTable<Users> tablaUsuarios = App.MobileService.GetTable<Users>();

        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cuando el usuario hace click en el campo, se saca la
        /// marca de agua. Ademas cambia el color de la letra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxUserNameLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbxUserNameLogin.Text == "Nombre Usuario")
            {
                tbxUserNameLogin.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                tbxUserNameLogin.Foreground = brush1;
            }
        }

        /// <summary>
        /// Si se deselecciona el campo, se regresa la marca de agua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxUserNameLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxUserNameLogin.Text == string.Empty)
            {
                tbxUserNameLogin.Text = "Nombre Usuario";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                tbxUserNameLogin.Foreground = brush1;
            }
        }

        /// <summary>
        /// al hacer click en e campo de password, hace desaparecer la palabra Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBoxLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBoxLogin.Password.Length == 0)
                tbxPasswordLogin.Text = string.Empty;
        }

        /// <summary>
        /// al sacar el mouse del campo password, si no hay nada escrito, 
        /// aparece la marca de agua password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBoxLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBoxLogin.Password.Length == 0)
                tbxPasswordLogin.Text = "Password";
        }

        private void btnLogin_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cargarUsuario();
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private async void cargarUsuario() 
        {
            try
            {
                //debug
                MessageBox.Show("Password escrita: " + PasswordBoxLogin.Password);

                //MessageBox.Show("debug de categoria: " + Globales.categoria);
                usuario = await tablaUsuarios
                    .Where(tablaTemporal => ((tablaTemporal.password == PasswordBoxLogin.Password) & (tablaTemporal.nombre == tbxUserNameLogin.Text)))
                    .ToCollectionAsync();

               //verificar si ingreso bien o no la Pass
                if (usuario.Count != 0)
                {
                    MessageBox.Show("Ingreso exitoso");
                    Globales._login = true;
                }
                else
                    MessageBox.Show("La contraseña o usuario son incorrectas");        
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "No se pudo conectar", MessageBoxButton.OK);
            }
            
        }

        /// <summary>
        /// si hace click en registrar, manda a la ventana de registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //NavigationService.Navigate(new Uri("/Registar.xaml", UriKind.Relative));
            Horario a = new Horario("247");
            MessageBox.Show("" + a.estaAbierto());
        }

    }
}