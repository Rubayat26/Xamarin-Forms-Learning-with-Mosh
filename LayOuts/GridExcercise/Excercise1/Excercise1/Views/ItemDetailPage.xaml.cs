using Excercise1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Excercise1.Views
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