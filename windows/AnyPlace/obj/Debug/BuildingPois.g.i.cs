﻿#pragma checksum "C:\Users\panayiotis\Desktop\AnyPlace\AnyPlace\AnyPlace\BuildingPois.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CF60DFE9EE00FC3D2A655AD44A2EBD5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class BuildingPois : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Button btn_source;
        
        internal System.Windows.Controls.Button btn_poiInfo;
        
        internal System.Windows.Controls.Button btn_navigateHere;
        
        internal System.Windows.Controls.Grid grid_details;
        
        internal System.Windows.Controls.TextBlock txt_description;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/BuildingPois.xaml", System.UriKind.Relative));
            this.btn_source = ((System.Windows.Controls.Button)(this.FindName("btn_source")));
            this.btn_poiInfo = ((System.Windows.Controls.Button)(this.FindName("btn_poiInfo")));
            this.btn_navigateHere = ((System.Windows.Controls.Button)(this.FindName("btn_navigateHere")));
            this.grid_details = ((System.Windows.Controls.Grid)(this.FindName("grid_details")));
            this.txt_description = ((System.Windows.Controls.TextBlock)(this.FindName("txt_description")));
        }
    }
}

