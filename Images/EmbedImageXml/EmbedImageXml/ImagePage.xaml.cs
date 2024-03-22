using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmbedImageXml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromResource("EmbedImageXml.Images.background.jpg");  //This line is used when the image is added from codebehind
        }
    }
}