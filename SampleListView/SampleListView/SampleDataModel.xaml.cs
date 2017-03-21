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
        }

        public class ListViewDataModelVM
        {
            private List<ListItem> listData;
            public ListViewDataModelVM()
            {
                listData = new List<ListItem>()
                {
                    new ListItem { Title="Mystic", Description="Team Mystic with blue badge" },
                    new ListItem { Title="Instinct", Description="Team Instinct with yellow badge" },
                    new ListItem { Title="Valor", Description="Team Valor with red badge" }
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
