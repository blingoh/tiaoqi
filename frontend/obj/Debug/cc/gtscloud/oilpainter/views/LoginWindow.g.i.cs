﻿#pragma checksum "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF58A4490C3FEF263A019C31048575B3"
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
using WpfAnimatedGif;
using frontend.cc.gtscloud.oilpainter.views;


namespace frontend.cc.gtscloud.oilpainter.views {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkRememberPasasword;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gifLoading;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblLoginError;
        
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
            System.Uri resourceLocater = new System.Uri("/frontend;component/cc/gtscloud/oilpainter/views/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
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
            
            #line 10 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
            ((frontend.cc.gtscloud.oilpainter.views.LoginWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.OnLoginWindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
            this.txtUserName.GotFocus += new System.Windows.RoutedEventHandler(this.OnInputFocused);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 26 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
            this.txtPassword.GotFocus += new System.Windows.RoutedEventHandler(this.OnInputFocused);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkRememberPasasword = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\..\cc\gtscloud\oilpainter\views\LoginWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.OnLoginButtonClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gifLoading = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.lblLoginError = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
