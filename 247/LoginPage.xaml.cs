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

namespace _247
{
    public partial class LoginPage : PhoneApplicationPage
    {
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

        }

        private void btnRegistrar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Registar.xaml", UriKind.Relative));
        }
    }
}