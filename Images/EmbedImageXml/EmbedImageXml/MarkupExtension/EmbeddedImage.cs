using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmbedImageXml   // When we directly create a cs file here the namespace becomes EmbedImageXml.EmbeddedImage,
                          //so we need to remove the EmbedImageXml from the namespace
{
   // [ContentProperty("ResourceId")]  // Commenting this line will not allow us to use the
                                       //ResourceId property in the xaml file without
                                       //specifying the property name in the xaml file
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ResourceId == null)
                return null;

            return ImageSource.FromResource(ResourceId);
        }
    }
}
