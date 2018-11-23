using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(Dateizugriff.Droid.AndroidSQLiteHelper))]
namespace Dateizugriff.Droid
{
    public class AndroidSQLiteHelper : ISQLiteHelper
    {
        public SQLiteConnection GetConnection()
        {
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, "meineDB.sqlite"); // Pfad + Dateiname
            // System.IO
            return new SQLiteConnection(fullPath);
        }
    }
}