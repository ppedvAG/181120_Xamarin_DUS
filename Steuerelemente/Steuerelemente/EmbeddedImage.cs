using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Steuerelemente
{
    class EmbeddedImage : IMarkupExtension
    {
        public string ImageID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ImageID))
                return null;

            return ImageSource.FromResource(ImageID);
        }
    }
}
