using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dateizugriff
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // con = DependencyService.Get<ISQLiteHelper>().GetConnection();

            // con.CreateTable(typeof(ToDoItem)); // Erstellt eine Tabelle für den Datentyp X, sofern nicht vorhanden
            App.Current.Properties["Wert1"] = 42; 
            App.Current.Properties["Wert2"] = "lalala"; 
            App.Current.Properties["Wert3"] = 12.5;
        }

        private SQLiteConnection con;


        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextHelper>();
            service.SaveText(entryEingabe.Text, "demo.txt");
            DisplayAlert("Speichern", "Datei wurde erfolgreich gespeichert !", "Yay !");
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextHelper>();
            DisplayAlert("Laden", service.LoadText("demo.txt"), "Yay !");
        }

        private void ButtonToDoItem_Clicked(object sender, EventArgs e)
        {
            ToDoItem item = new ToDoItem();
            item.Title = entryToDoItem.Text;
            item.Details = "erstellt by Michi :)";

            con.Insert(item);
        }

        private void ListViewToDoItems_Refreshing(object sender, EventArgs e)
        {
            listViewToDoItems.ItemsSource = con.Table<ToDoItem>().ToList(); // auch LINQ !!!
            listViewToDoItems.EndRefresh();
        }
    }
}
