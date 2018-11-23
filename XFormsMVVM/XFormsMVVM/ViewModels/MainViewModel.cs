
using Geschäftslogik.Models;
using Geschäftslogik.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XFormsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // Properties
        // Commands
        // Zugriff auf PersonenService ...
        public MainViewModel()
        {
            // Controllfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new Command(GetPersonen);
        }
        private void GetPersonen(object obj)
        {
            PersonenListe = service.GetPersonen();
            // ObservableCollection<T>  => Benachrichtigungen für Add/Remove/Clear
            // BindingList<T> => T.Vorname => Benachrichtigung bei Property-Änderungen
        }
        private readonly PersonenService service;
        public Command GetPersonenCommand { get; set; }

        private IList<Person> personenListe;
        public IList<Person> PersonenListe
        {
            get => personenListe;
            set => SetValue(ref personenListe, value);
        }
    }
}
