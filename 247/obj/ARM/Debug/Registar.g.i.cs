﻿#pragma checksum "C:\Users\JeanPaul\Source\Repos\SunshineLab\247\Registar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4230B873A9962B6E138D39D2FC54208B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34011
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace _247 {
    
    
    public partial class Registar : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image ImgPerfil;
        
        internal System.Windows.Controls.TextBox txtNombre;
        
        internal System.Windows.Controls.TextBox txtCiudad;
        
        internal System.Windows.Controls.TextBox txtApellido;
        
        internal System.Windows.Controls.TextBox txtRegion;
        
        internal System.Windows.Controls.TextBox txtMail;
        
        internal System.Windows.Controls.TextBox txtPassword;
        
        internal System.Windows.Controls.TextBox txtConfirmarPassword;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/247;component/Registar.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ImgPerfil = ((System.Windows.Controls.Image)(this.FindName("ImgPerfil")));
            this.txtNombre = ((System.Windows.Controls.TextBox)(this.FindName("txtNombre")));
            this.txtCiudad = ((System.Windows.Controls.TextBox)(this.FindName("txtCiudad")));
            this.txtApellido = ((System.Windows.Controls.TextBox)(this.FindName("txtApellido")));
            this.txtRegion = ((System.Windows.Controls.TextBox)(this.FindName("txtRegion")));
            this.txtMail = ((System.Windows.Controls.TextBox)(this.FindName("txtMail")));
            this.txtPassword = ((System.Windows.Controls.TextBox)(this.FindName("txtPassword")));
            this.txtConfirmarPassword = ((System.Windows.Controls.TextBox)(this.FindName("txtConfirmarPassword")));
        }
    }
}

