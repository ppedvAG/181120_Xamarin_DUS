using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

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
            Toast.MakeText(this, "Hello World", ToastLength.Short).Show(); 
        }
    }
}