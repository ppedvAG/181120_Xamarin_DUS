using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Seite2Page : ContentPage
	{
		public Seite2Page (bool modal = false)
		{
			InitializeComponent ();
            if (modal)
                buttonZurück.IsVisible = true;
		}
        public Seite2Page()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            // Normal
            // Navigation.PopAsync();
            
            // Modal
            Navigation.PopModalAsync();
        }
    }
}