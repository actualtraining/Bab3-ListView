using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleListView.ViewModel
{
    public class BarangListViewModel : BindableObject
    {
        readonly Func<string, string, string, Task> displayAlertAction;
        private ObservableCollection<Barang> listBarang;

        public ObservableCollection<Barang> ListBarang
        {
            get { return listBarang; }
            set { listBarang = value; OnPropertyChanged("ListBarang"); }
        }

        public BarangListViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;

            listBarang = new ObservableCollection<Barang>()
            {
                new Barang { Kode="AA001",Nama="Printer Epson 1",Stok=11,HargaBeli=2000000,HargaJual = 2200000 },
                new Barang { Kode="AA002",Nama="Printer Epson 2",Stok=12,HargaBeli=2100000,HargaJual = 2300000 },
                new Barang { Kode="AA003",Nama="Printer Epson 3",Stok=15,HargaBeli=2300000,HargaJual = 2500000 }
            };

            MessagingCenter.Subscribe<Barang>(this, "BuyRequested", BuyRequested);
            MessagingCenter.Subscribe<Barang>(this, "SellRequested", (sender) =>
            {
                var barang = (Barang)sender;
                barang.Warna = Color.Red;
                displayAlertAction.Invoke("Keterangan", barang.Nama + " was clicked", "OK");
            });

            MessagingCenter.Subscribe<Barang>(this, "CommandRequested", CommandRequested);
            MessagingCenter.Subscribe<Barang>(this, "DeleteRequested", DeleteRequested);
        }

        private void DeleteRequested(Barang barang)
        {
            displayAlertAction.Invoke("Keterangan", barang.Nama + " was deleted", "OK");
        }

        private void CommandRequested(Barang barang)
        {
            displayAlertAction.Invoke("Keterangan", barang.Nama + " was requested", "OK");
        }

        private void BuyRequested(Barang barang)
        {
            displayAlertAction.Invoke("Keterangan", barang.Nama + " was clicked", "OK");
        }
    }
}
