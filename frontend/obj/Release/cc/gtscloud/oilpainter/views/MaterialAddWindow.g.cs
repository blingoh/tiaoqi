﻿#pragma checksum "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "346FEECC6E67184A795D02402A102645"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using frontend.cc.gtscloud.oilpainter.views;


namespace frontend.cc.gtscloud.oilpainter.views {
    
    
    /// <summary>
    /// MaterialAddWindow
    /// </summary>
    public partial class MaterialAddWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 119 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbMainMaterial;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGuhua;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbXishi;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/frontend;component/cc/gtscloud/oilpainter/views/materialaddwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbMainMaterial = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 121 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeleteMainButtonClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 122 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddMainButtonClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbGuhua = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 137 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeleteGuhuaButtonClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 138 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddGuhuaButtonClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbXishi = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 153 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeleteXishiButtonClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 154 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddXishiButtonClicked);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 157 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\MaterialAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddNewItemButtonClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

