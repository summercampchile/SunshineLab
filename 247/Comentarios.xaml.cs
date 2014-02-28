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
using Microsoft.WindowsAzure.MobileServices;

namespace _247
{
    public partial class Comentarios : PhoneApplicationPage
    {
        private IMobileServiceTable<Registrations> tablaRegistros = App.MobileService.GetTable<Registrations>();
        public Comentarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cuando se pierde el foco del cuadro de texto se escribe 
        /// el mensaje "Escriba un mensaje para la tienda" como 
        /// marca de agua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtComentario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtComentario.Text == string.Empty)
            {
                txtComentario.Text = "Escriba un mensaje para la tienda";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Gray;
                txtComentario.Foreground = brush1;
            }
        }

        /// <summary>
        /// Cuando se comienza a escribiren e cuadro de texto, borra la marca de agua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtComentario_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtComentario.Text == "Escriba un mensaje para la tienda")
            {
                txtComentario.Text = "";
                SolidColorBrush brush1 = new SolidColorBrush();
                brush1.Color = Colors.Black;
                txtComentario.Foreground = brush1;
            }
        }

        /// <summary>
        /// Al hacer click en e boton enviar, envia un mensaje a la 
        /// tienda y regresa al mapa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Globales._login)
            {
                sendInformation();
                MessageBox.Show("Enviando Mensaje");
                NavigationService.Navigate(new Uri("/Mapa.xaml", UriKind.Relative));
            }
            else 
            {
                MessageBox.Show("Es necesario ingresar como usuario para enviar mensaje a la tienda");
                NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
            }
        }

        private async void sendInformation() 
        {
            try
            {
                //extraer registros
                var registro = extractInformation();

                await tablaRegistros.InsertAsync(registro);
                MessageBox.Show("Comentario enviado");
               
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "No se pude conectar, no se registro", MessageBoxButton.OK);
            }
        }

        /// <summary>
        /// Toma la informacion necesaria para enviarla posteriormente al
        /// dueño de a tienda
        /// </summary>
        /// <returns></returns>
        private Registrations extractInformation() 
        {
            var registro = new Registrations();
            
            registro.Latitud = Globales.latitud;
            registro.Longitud = Globales.longitud;
            registro.Nombre = Globales.nombre;
            registro.NombreTienda = Globales.nombreTienda;
            registro.Categoria = Globales.categoria;
            registro.Comentario = txtComentario.Text;

            return registro;
        }
    }
}