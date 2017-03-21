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
            get { return nama; }
            set { nama = value; OnPropertyChanged("Nama"); }
        }

        private int stok;
        public int Stok
        {
            get { return stok; }
            set { stok = value; OnPropertyChanged("Stok"); }
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

        private Color warna;
        public Color Warna
        {
            get { return warna; }
            set { warna = value; OnPropertyChanged("Warna"); }
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
            set { sellcommand = value; OnPropertyChanged("SellCommand"); }
        }

        public Barang()
        {
            Warna = Color.Black;
            BuyCommand = new Command(BuyRequested);
            SellCommand = new Command(SellRequested);

            MoreCommand = new Command(CommandRequested);
            DeleteCommand = new Command(DeleteRequested);
        }

        private void DeleteRequested()
        {
            MessagingCenter.Send<Barang>(this, "DeleteRequested");
        }

        private void CommandRequested()
        {
            MessagingCenter.Send<Barang>(this, "CommandRequested");
        }

        private void SellRequested()
        {
            MessagingCenter.Send<Barang>(this, "SellRequested");
        }

        private void BuyRequested()
        {
            MessagingCenter.Send<Barang>(this, "BuyRequested");
        }

        private Command moreCommand;
        public Command MoreCommand
        {
            get { return moreCommand; }
            set { moreCommand = value; }
        }

        private Command deleteCommand;
        public Command DeleteCommand
        {
            get { return deleteCommand; }
            set { deleteCommand = value; }
        }


    }
}
