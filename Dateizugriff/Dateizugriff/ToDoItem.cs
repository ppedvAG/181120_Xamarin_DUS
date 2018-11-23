using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dateizugriff
{
   
    class ToDoItem
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
