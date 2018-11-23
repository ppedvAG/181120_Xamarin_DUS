using Geschäftslogik.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geschäftslogik.Services
{
    public class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
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
        }
    }
}
