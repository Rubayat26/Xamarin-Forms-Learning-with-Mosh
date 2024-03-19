using System.ComponentModel;
using Xamarin.Forms;
using XamEssentExSolution.ViewModels;

namespace XamEssentExSolution.Views
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