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
using Wpf.Ui.Common.Interfaces;
using SIDIAv2.ViewModel;

namespace SIDIAv2
{
    /// <summary>
    /// Interaction logic for KelolaBarang.xaml
    /// </summary>
    public partial class KelolaBarang : INavigableView<KelolaBarangViewModel>
    {
        public KelolaBarangViewModel ViewModel
        {
            get;
        }
        public KelolaBarang(KelolaBarangViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
            Loaded += OnLoaded;
        }
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
