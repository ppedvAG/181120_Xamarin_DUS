using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Net;
using Android.Graphics;

namespace HelloKitten
{
    [Activity(Label = "Mein erstes Android-Programm", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button buttonKätzchenLaden;
        private EditText editTextHöhe;
        private EditText editTextBreite;
        private ImageView imageViewKätzchen;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            buttonKätzchenLaden = FindViewById<Button>(Resource.Id.buttonKätzchenLaden);
            editTextHöhe = FindViewById<EditText>(Resource.Id.editTextHöhe);
            editTextBreite = FindViewById<EditText>(Resource.Id.editTextBreite);
            imageViewKätzchen = FindViewById<ImageView>(Resource.Id.imageViewKätzchen);

            buttonKätzchenLaden.Click += ButtonKätzchenLaden_Click;
        }

        private void ButtonKätzchenLaden_Click(object sender, System.EventArgs e)
        {
            // Variante 1) Hello World
            // Toast.MakeText(this, "Hello World", ToastLength.Short).Show(); 

            // 1) Bild von placekitten.com herunterladen

            if(string.IsNullOrWhiteSpace(editTextHöhe.Text)|| string.IsNullOrWhiteSpace(editTextBreite.Text))
            {
                Toast.MakeText(this, "Bitte geben Sie die Höhe UND die Breite ein", ToastLength.Long).Show(); 
                return;
            }

            int höhe = Convert.ToInt32(editTextHöhe.Text);
            int breite = Convert.ToInt32(editTextBreite.Text);

            if (höhe <=0 || breite <= 0)
            {
                Toast.MakeText(this, "Höhe oder Breite ist ungültig", ToastLength.Long).Show();
                return;
            }

            // text wird automatisch als url angezeigt und eingefärbt -> "Enable single-click URL-Navigation"
            byte[] imageData;
            using (WebClient client = new WebClient())
            {
                imageData = client.DownloadData($"http://placekitten.com/g/{breite}/{höhe}");
            }

            // byte[] zu einer Bitmap machen und anzeigen

            imageViewKätzchen.SetImageBitmap(BitmapFactory.DecodeByteArray(imageData, 0, imageData.Length));

        }
    }
}