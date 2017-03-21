using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleDataModel : ContentPage
    {
       
        public SampleDataModel()
        {
            InitializeComponent();
            BindingContext = new ListViewDataModelVM();

            lvData.ItemTapped += LvData_ItemTapped;
        }

        private async void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem currItem = (ListItem)e.Item;
            await DisplayAlert("Keterangan", "Anda memilih Kode: " + currItem.Kode,"OK");
        }

        public class ListViewDataModelVM
        {
            private List<ListItem> listData;
            public ListViewDataModelVM()
            {
                listData = new List<ListItem>()
                {
                    new ListItem { Kode="AA001", Title="Mystic", Description="Team Mystic with blue badge" },
                    new ListItem { Kode="AA002", Title="Instinct", Description="Team Instinct with yellow badge" },
                    new ListItem { Kode="AA003", Title="Valor", Description="Team Valor with red badge" }
                };
            }

            public List<ListItem> ListItems
            {
                get
                {
                    return listData;
                }
                set
                {
                    listData = value;
                }
            }


        }
    }
}
