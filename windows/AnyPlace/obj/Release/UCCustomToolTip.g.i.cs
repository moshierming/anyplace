﻿#pragma checksum "C:\Users\panayiotis\Desktop\AnyPlace\AnyPlace\AnyPlace\UCCustomToolTip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0E72CEC5F2BBEC56029ACBD7E2551E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace AnyPlace {
    
    
    public partial class UCCustomToolTip : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Image imgmarker;
        
        internal Microsoft.Phone.Controls.ContextMenu c_menu;
        
        internal Microsoft.Phone.Controls.MenuItem nav_here;
        
        internal Microsoft.Phone.Controls.MenuItem source_poi;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/UCCustomToolTip.xaml", System.UriKind.Relative));
            this.imgmarker = ((System.Windows.Controls.Image)(this.FindName("imgmarker")));
            this.c_menu = ((Microsoft.Phone.Controls.ContextMenu)(this.FindName("c_menu")));
            this.nav_here = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("nav_here")));
            this.source_poi = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("source_poi")));
        }
    }
}

