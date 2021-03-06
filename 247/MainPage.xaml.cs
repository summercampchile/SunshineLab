﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using _247.Resources;

namespace _247
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void cambiarPagina(int categoria)
        {
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            Globales.categoria = categoria;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
 		NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));			
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            cambiarPagina(Globales.URGENCIA);
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            cambiarPagina(Globales.FARMACIA);
			
        }

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.VETERINARIO);
        }

        private void Image_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.SUPERMERCADO);
        }

        private void Image_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.HOSPEDAJE);
           
        }

        private void Image_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.SERVICIOS);
        }

        private void Image_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.RESTAURANT);  
        }

        private void Image_Tap_7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.BOTILLERIA);
        }

        private void Image_Tap_8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(Globales.ENTRETENCION);
        }

        private void btnIngreso_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Registar.xaml", UriKind.Relative));
        }
    }
}