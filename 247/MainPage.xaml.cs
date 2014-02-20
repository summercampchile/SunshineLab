using System;
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
        //Constantes que indican a categoria a la que se esta traspasando
        public static int URGENCIA = 0, FARMACIA = 1,
                VETERINARIO = 2, SUPERMERCADO = 3, HOSPEDAJE = 4,
                SERVICIOS = 5, RESTAURANT = 6, BOTILLERIA = 7,
                ENTRETENCION = 8;
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
            cambiarPagina(URGENCIA);
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            cambiarPagina(FARMACIA);
			
        }

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(VETERINARIO);
            
			
        }

        private void Image_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(SUPERMERCADO);
            
        }

        private void Image_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(HOSPEDAJE);
           
        }

        private void Image_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(SERVICIOS);
            
        }

        private void Image_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(RESTAURANT);
           
        }

        private void Image_Tap_7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(BOTILLERIA);
            
        }

        private void Image_Tap_8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cambiarPagina(ENTRETENCION);
            
        }

        private void Image_Tap_9(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("/Registar.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}