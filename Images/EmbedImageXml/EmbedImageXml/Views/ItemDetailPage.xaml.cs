using EmbedImageXml.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmbedImageXml.Views
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