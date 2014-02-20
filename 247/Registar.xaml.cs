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
    }
}