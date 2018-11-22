using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private List<Person> data;

        private void ButtonPerson_Clicked(object sender, EventArgs e)
        {
            data = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=12m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=300m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=44400m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=-500m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=60,Kontostand=666600m},
                new Person{Vorname="Klara",Nachname="Fall",Alter=70,Kontostand=77770m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=80,Kontostand=88880m},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=90,Kontostand=99990m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=-100m},
            };
            listViewPersonen.ItemsSource = data;
        }

        private void SearchBarName_TextChanged(object sender, TextChangedEventArgs e)
        {
            listViewPersonen.ItemsSource =
                data.Where(x => x.Vorname.StartsWith(searchBarName.Text)).ToList();
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            data = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=12m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=300m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=44400m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=-500m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=60,Kontostand=666600m},
                new Person{Vorname="Klara",Nachname="Fall",Alter=70,Kontostand=77770m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=80,Kontostand=88880m},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=90,Kontostand=99990m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=-100m},
            };
            listViewPersonen.ItemsSource = data;

            // 2 Varianten um das "Refreshing" zu beenden

            // 1)
            listViewPersonen.EndRefresh();

            //2)
            // listViewPersonen.IsRefreshing = false;
        }

        private bool isRowEven;
        private void TextCell_Appearing(object sender, EventArgs e)
        {
            if (this.isRowEven)
            {
                var tc = sender as TextCell;
                if(tc != null)
                    tc.TextColor = Color.Gray;
            }

            this.isRowEven = !this.isRowEven;
        }

        //private void SliderWert_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    labelWert.Text = $"Wert ist: {sliderWert.Value.ToString()}";
        //}
    }
}
