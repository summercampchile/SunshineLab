using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml.Linq;
using _247.Resources;

namespace _247
{
    public partial class AboutPage : PhoneApplicationPage
    {
        public AboutPage()
        {
            InitializeComponent();
            UpdateVersionString();
        }

        private void UpdateVersionString()
        {
            string appVersion = XDocument.Load("WMAppManifest.xml").Root.Element("App").Attribute("Version").Value;
            VersionText.Text = AppResources.AboutPageVersionText + appVersion;
        }
    }
}