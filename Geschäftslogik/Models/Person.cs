﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Geschäftslogik.Models
{
    // Models -> POCO 
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }
}
