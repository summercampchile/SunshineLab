using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.WindowsAzure.MobileServices;

namespace _247
{
    public partial class Informacion : PhoneApplicationPage
    {
        

        public Informacion()
        {
            InitializeComponent();
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
		    NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del Cruz Verde
            
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del simi
            

        }

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del ahumada
           

        }

        private void Image_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del dr ahorro


        }
    }
}