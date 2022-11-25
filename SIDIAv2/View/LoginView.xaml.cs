using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Wpf.Ui.Mvvm.Services;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Mvvm.Contracts;
using SIDIAv2.ViewModel;
using SIDIAv2.Services;

namespace SIDIAv2.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : INavigationWindow
    {
        private IPageService _pageService;
        public LoginView(IPageService pageService)
        {
            _pageService = pageService;
            InitializeComponent();
        }

        public Frame GetFrame()
            => null;

        public INavigation GetNavigation()
            => null;

        public bool Navigate(Type pageType)
            => false;

        public void SetPageService(IPageService pageService)
        {

        }

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(new MainWindowViewModel(), new NavigationService(), _pageService);
            mainWindow.Show();
            this.Close();
        }
    }
}
