using StacLayExcer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StacLayExcer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}