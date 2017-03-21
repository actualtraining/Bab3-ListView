using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleListView
{
    public class ListItem : INotifyPropertyChanged
    {
        private string kode;
        public string Kode
        {
            get { return kode; }
            set { kode = value; OnPropertyChanged("Kode"); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        private string gambar;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        public string Gambar
        {
            get { return gambar; }
            set { gambar = value; OnPropertyChanged("Gambar"); }
        }


    }


}
