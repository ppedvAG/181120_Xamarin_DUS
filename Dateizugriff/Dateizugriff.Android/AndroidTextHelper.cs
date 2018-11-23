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

[assembly: Xamarin.Forms.Dependency(typeof(Dateizugriff.Droid.AndroidTextHelper))]
namespace Dateizugriff.Droid
{
    public class AndroidTextHelper : ITextHelper
    {
        public string LoadText(string path)
        {
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, path); // Pfad + Dateiname
            // System.IO
            return File.ReadAllText(fullPath);
        }

        public void SaveText(string content, string path)
        {
            // Ohne "WRITE_EXTERNAL_STORAGE" => 
            // mit "WriteExternalStorage" => "überall"
            // /data/data/[appname]/files
            // System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            
            // Emulator: /storage/emulated/0/....  <== BERECHTIGUNG SETZEN !!!
            // Android.OS.Environment.DirectoryPictures

            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, path); // Pfad + Dateiname
            // System.IO
            File.WriteAllText(fullPath, content);
        }
    }
}