using SIDIAv2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Wpf.Ui.Common;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Mvvm.Contracts;

using SIDIAv2.View;

namespace SIDIAv2;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// 

public partial class MainWindow : INavigationWindow
{
    private IPageService _pageService;
    public MainWindowViewModel ViewModel
    {
        get;
    }

    public MainWindow(MainWindowViewModel viewModel, INavigationService navigationService, IPageService pageService)
    {
        ViewModel = viewModel;
        DataContext = this;
        _pageService = pageService;

        InitializeComponent();
        SetPageService(pageService);
        navigationService.SetNavigationControl(RootNavigation);

        Navigate(typeof(Dashboard));
    }
    public Frame GetFrame()
        => RootFrame;

    public INavigation GetNavigation()
        => RootNavigation;

    public bool Navigate(Type pageType)
        => RootNavigation.Navigate(pageType);

    public void SetPageService(IPageService pageService)
        => RootNavigation.PageService = pageService;

    public void ShowWindow()
        => Show();

    public void CloseWindow()
        => Close();

    private void TrayMenuItem_OnClick(object sender, RoutedEventArgs e)
    {
        if (sender is not MenuItem menuItem)
            return;

        System.Diagnostics.Debug.WriteLine($"DEBUG | Tray clicked: {menuItem.Tag}", "SIDIAv2");
    }

    private void SidebarNavigate_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Logout_OnClick(Object sender, RoutedEventArgs e)
    {
        LoginView login = new LoginView(_pageService);
        login.Show();
        this.CloseWindow();
    }

    private void RootNavigation_OnNavigated(INavigation sender, RoutedNavigationEventArgs e)
    {
        RootFrame.Margin = new Thickness(
            left: 0,
            top: sender?.Current?.PageTag == "dashboard" ? -69 : 0,
            right: 0,
            bottom: 0);
    }

}