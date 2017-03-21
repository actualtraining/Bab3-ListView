using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleListView
{
    public class Barang : BindableObject
    {
        private string kode;
        public string Kode
        {
            get { return kode; }
            set { kode = value; OnPropertyChanged("Kode"); }
        }

        private string nama;
        public string Nama
        {
            get { return Nama; }
            set { Nama = value; OnPropertyChanged("Nama"); }
        }

        private int stok;
        public int Stok
        {
            get { return stok; }
            set { stok = value; }
        }

        private decimal hargaBeli;
        public decimal HargaBeli
        {
            get { return hargaBeli; }
            set { hargaBeli = value; OnPropertyChanged("HargaBeli"); }
        }

        private decimal hargaJual;
        public decimal HargaJual
        {
            get { return hargaJual; }
            set { hargaJual = value; OnPropertyChanged("HargaJual"); }
        }

        private Command buycommand;
        public Command BuyCommand
        {
            get { return buycommand; }
            set { buycommand = value; OnPropertyChanged("BuyCommand"); }
        }

        private Command sellcommand;
        public Command SellCommand
        {
            get { return sellcommand; }
            set { sellcommand = value; }
        }

        public Barang()
        {
            BuyCommand = new Command(BuyRequested);
            SellCommand = new Command(SellRequested);
        }

        private void SellRequested()
        {
            MessagingCenter.Send<Barang>(this, "SellRequested");
        }

        private void BuyRequested()
        {
            MessagingCenter.Send<Barang>(this, "BuyRequested");
        }
    }
}
