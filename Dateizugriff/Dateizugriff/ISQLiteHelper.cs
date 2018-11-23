using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dateizugriff
{
    public interface ISQLiteHelper
    {
        SQLiteConnection GetConnection();
    }
}
