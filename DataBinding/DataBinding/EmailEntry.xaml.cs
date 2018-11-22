using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmailEntry : ContentView
	{
		public EmailEntry ()
		{
			InitializeComponent ();
            this.BindingContext = this; // "Ich" selbst bin meine eigene Datenquelle fürs Binding
        }


        // BindableProperties - propdp + TAB + TAB generiert und an Xamarin.Forms angepasst
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(EmailEntry),string.Empty);





        Regex r = new Regex(@"\b[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-z]{2,3}\b");
        private void EntryEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = r.Match(entryEmail.Text);
            labelValidierung.IsVisible = ! result.Success;
        }
    }
}