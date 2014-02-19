using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Facebook.Client;
using Facebook;
using System.Windows.Media.Imaging;

namespace _247.Pages
{
    public partial class LandingPage : PhoneApplicationPage
    {
        public LandingPage()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            var fb = new FacebookClient(App.AccessToken);

            fb.GetCompleted += (o, e) =>
            {
                if (e.Error != null)
                {
                    Dispatcher.BeginInvoke(() => MessageBox.Show(e.Error.Message));
                    return;
                }

                var result = (IDictionary<string, object>)e.GetResultData();

                Dispatcher.BeginInvoke(() =>
                {
                    var profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}&access_token={2}", App.FacebookId, "square", App.AccessToken);

                    this.MyImage.Source = new BitmapImage(new Uri(profilePictureUrl));
                    this.MyName.Text = String.Format("{0} {1}", (string)result["first_name"], (string)result["last_name"]);
                });
            };

            fb.GetTaskAsync("me");
        }

        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Image_Tap_10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }

        private void Button_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FacebookLoginPage.xaml", UriKind.Relative));
        }
    }
}