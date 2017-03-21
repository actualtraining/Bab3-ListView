using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleListView.ViewModel;

namespace SampleListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarangListPage : ContentPage
    {
        public BarangListPage()
        {
            InitializeComponent();
            BindingContext = new BarangListViewModel(DisplayAlert);
        }
    }
}
