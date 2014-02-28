using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Cliente_24_7.Resources;
using Microsoft.WindowsAzure.MobileServices;

namespace Cliente_24_7
{
    public partial class MainPage : PhoneApplicationPage
    {

        private MobileServiceCollection<Registrations, Registrations> registros;
        private IMobileServiceTable<Registrations> tablaRegistros = App.MobileService.GetTable<Registrations>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void UpdateInfo() 
        {
            try
            {
                //MessageBox.Show("debug de categoria: " + Globales.categoria);
                registros = await tablaRegistros
                    .ToCollectionAsync();

                foreach (Registrations reg in registros) 
                {
                    LlenarCampos(reg);
                }

                MessageBox.Show("info cargada exitorsamente");
                if(registros.Count <= 0)
                    MessageBox.Show("vacio");
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error al cargar los lugares", MessageBoxButton.OK);
            }
        }

        private void LlenarCampos(Registrations registro)
        {
            txtComentario.Text = registro.Comentario;
            txtNombre.Text = registro.Nombre;
            txtOrigen.Text = registro.NombreTienda;
            Globales.categoria = registro.Categoria;
            Globales.latitud = registro.Latitud;
            Globales.longitud = registro.Longitud; 
        }

        /// <summary>
        /// Actualizar la informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToMap_Click(object sender, RoutedEventArgs e)
        {
           
            //Manda al Mapa
            NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
        }

        private void btnActualizar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            UpdateInfo();
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}