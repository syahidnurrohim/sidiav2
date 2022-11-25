using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using Wpf.Ui.Common.Interfaces;

namespace SIDIAv2.ViewModel;

public class PegawaiAbstract
{
    public string Nama { get; set; }
    public string Username { set; get; }
    public string JenisKelamin { get; set; }
    public int Umur { get; set; }
    public string Alamat { get; set; }
}

public class KelolaPegawaiViewModel : ObservableObject, INavigationAware
{
    private bool _dataInitialized = false;
    private IEnumerable<PegawaiAbstract> _dataPegawai = new PegawaiAbstract[] { };

    public IEnumerable<PegawaiAbstract> DataPegawai
    {
        get { return _dataPegawai; }
        set { SetProperty(ref _dataPegawai, value); }
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
        DataPegawai = new List<PegawaiAbstract>()
        {
            new()
            {
                Nama = "Syahid Nurrohim",
                Username = "21.11.4435",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            },
            new()
            {
                Nama = "Dimas Ariyanto",
                Username = "21.11.4408",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            },
            new()
            {
                Nama = "Aldhi Nugroho",
                Username = "21.11.4431",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            },
            new()
            {
                Nama = "Rahman Hakim",
                Username = "21.11.4416",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            },
            new()
            {
                Nama = "Galih Anggriawan",
                Username = "21.11.4450",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            },
            new()
            {
                Nama = "Akmal Rafi Fadilla",
                Username = "21.11.4414",
                JenisKelamin = "Laki-Kali",
                Umur = 20,
                Alamat = "DIY"
            }
        };

        _dataInitialized = true;
    }
}