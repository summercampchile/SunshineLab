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
            Globales.latitud = -33.4165883;
            Globales.longitud = -70.5953938;
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del simi
            Globales.latitud = -33.4425058;
            Globales.longitud = -70.6514774;

        }

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del ahumada
            Globales.latitud = -33.41631;
            Globales.longitud = -70.5938286;

        }

        private void Image_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            //manda a las coordenadas del dr ahorro
            Globales.latitud = -33.4370932;
            Globales.longitud = -70.648306;

        }
    }
}