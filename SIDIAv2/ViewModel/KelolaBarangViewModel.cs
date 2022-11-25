using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using Wpf.Ui.Common.Interfaces;

namespace SIDIAv2.ViewModel;

public class BarangAbstract
{
    public string Barang { get; set; }
    public float Harga { get; set; }
    public int Jumlah { get; set; }
    public float Total { get; set; }
}

public class KelolaBarangViewModel : ObservableObject, INavigationAware
{
    private bool _dataInitialized = false;
    private IEnumerable<BarangAbstract> _dataBarang = new BarangAbstract[] {};

    public IEnumerable<BarangAbstract> DataBarang
    {
        get { return _dataBarang; }
        set { SetProperty(ref _dataBarang, value); }
    }
    public void OnNavigatedTo()
    {
        if (!_dataInitialized)
            InitializeData();
    }

    public void OnNavigatedFrom()
    {
    }

    private void InitializeData()
    {
        DataBarang = new List<BarangAbstract>()
        {
            new ()
            {
                Barang = "Barang 1",
                Harga = 1000000,
                Jumlah = 20,
                Total = 1000000 * 20
            },
            new ()
            {
                Barang = "Barang 1",
                Harga = 1000000,
                Jumlah = 20,
                Total = 1000000 * 20
            },
            new ()
            {
                Barang = "Barang 1",
                Harga = 1000000,
                Jumlah = 20,
                Total = 1000000 * 20
            }
        };

        _dataInitialized = true;
    }
}