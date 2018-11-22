using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Steuerelemente
{

    public enum Wochentage { Montag,Dienstag,Mittwoch,Donnerstag,Freitag,Samstag,Sonntag}
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //UriImageSource source = new UriImageSource();
            //source.Uri = new Uri("....");
            //source.CachingEnabled = true; // Standardfall: true
            //source.CacheValidity = TimeSpan.FromMinutes(10); // Standardfall: 24h


            // <Image x:Name="imageBild"/>
            // imageBild.Source = ImageSource.FromResource("Steuerelemente.Images.hamster.jpg");


            //if(Device.Idiom == TargetIdiom.Tablet)
            //{
            //    if(Device.RuntimePlatform == "Bananaphone")
            //    {
            //        // COde für Android-Tablets
            //    }
            //}
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            //entryUsername.Text = e.Value.ToString();

            Editor ed = new Editor();

            StackLayout sl = new StackLayout();
        }
    }
}
