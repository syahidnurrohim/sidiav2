#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "180DEA10A5F867C24B65F8DA340D5F394BC6DCC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIDIAv2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Wpf.Ui;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Navigation;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;
using Wpf.Ui.ValidationRules;


namespace SIDIAv2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Wpf.Ui.Controls.UiWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Sidebar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationFluent RootNavigation;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationItem Home;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationItem Kelola_barang;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationItem Kelola_admin;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationItem Kelola_pegawai;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame RootFrame;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Snackbar RootSnackbar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIDIAv2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Sidebar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.RootNavigation = ((Wpf.Ui.Controls.NavigationFluent)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.RootNavigation.Navigated += new Wpf.Ui.Common.RoutedNavigationEvent(this.RootNavigation_OnNavigated);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Home = ((Wpf.Ui.Controls.NavigationItem)(target));
            return;
            case 4:
            this.Kelola_barang = ((Wpf.Ui.Controls.NavigationItem)(target));
            return;
            case 5:
            this.Kelola_admin = ((Wpf.Ui.Controls.NavigationItem)(target));
            return;
            case 6:
            this.Kelola_pegawai = ((Wpf.Ui.Controls.NavigationItem)(target));
            return;
            case 7:
            
            #line 67 "..\..\..\MainWindow.xaml"
            ((Wpf.Ui.Controls.NavigationItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RootFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 9:
            this.RootSnackbar = ((Wpf.Ui.Controls.Snackbar)(target));
            return;
            case 10:
            
            #line 127 "..\..\..\MainWindow.xaml"
            ((Wpf.Ui.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TrayMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 132 "..\..\..\MainWindow.xaml"
            ((Wpf.Ui.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TrayMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 137 "..\..\..\MainWindow.xaml"
            ((Wpf.Ui.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TrayMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 143 "..\..\..\MainWindow.xaml"
            ((Wpf.Ui.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TrayMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

