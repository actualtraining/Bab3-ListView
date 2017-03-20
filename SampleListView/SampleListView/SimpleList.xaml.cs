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
    public partial class SimpleList : ContentPage
    {
        public SimpleList()
        {
            InitializeComponent();

            List<string> listData = new List<string>() { "First", "Second", "Third"};
            lvData.ItemsSource = listData;


            lvData.ItemTapped += LvData_ItemTapped;
        }

        private async void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Tapped", e.Item.ToString() + " was selected", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
