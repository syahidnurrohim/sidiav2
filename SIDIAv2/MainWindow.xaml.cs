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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Interfaces;


namespace SIDIAv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Dashboard());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void SidebarNavigate_Click(object sender, RoutedEventArgs e)
        {
            NavigationItem navigationItem = (NavigationItem)sender;
            string name = navigationItem.Name;
            Page page = new Dashboard();

            switch (name)
            {
                case "Home":
                    page = new Dashboard();
                    break;
                case "Product":
                    page = new Product();
                    break;
            }

            MainFrame.Navigate(page);
        }

    }
}
