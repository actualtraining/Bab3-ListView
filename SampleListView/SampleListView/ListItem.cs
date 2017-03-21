using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleListView
{
    public class ListItem : BindableObject
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

    }


}
