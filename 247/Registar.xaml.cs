using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace _247
{
    public partial class Registar : PhoneApplicationPage
    {
        public Registar()
        {
            InitializeComponent();
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Informacion.xaml", UriKind.Relative));
        }
    }
}