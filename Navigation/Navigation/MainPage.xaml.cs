using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonMessageBox_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nachricht", "Hallo Welt aus Xamarin.Forms", "Ja", "Nein");

            DisplayActionSheet("Wähle ein Obst", "Bestätigen", 
                "Abbrechen", new string[] { "Apfel", "Birne", "Banane" });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Seite2Page(false));
        }

        private void ButtonModalNavigation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2Page(true));
        }
    }
}
