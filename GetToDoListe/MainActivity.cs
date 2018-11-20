using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net;
using Newtonsoft.Json;
using System.Linq;

namespace GetToDoListe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button buttonToDo;
        private ListView listViewToDo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            buttonToDo = FindViewById<Button>(Resource.Id.buttonGetToDoListe);
            listViewToDo = FindViewById<ListView>(Resource.Id.listViewToDo);

            buttonToDo.Click += ButtonToDo_Click;
        }

        private void ButtonToDo_Click(object sender, System.EventArgs e)
        {
            string json;
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString("https://jsonplaceholder.typicode.com/todos");
            }

            ToDoItem[] items = JsonConvert.DeserializeObject<ToDoItem[]>(json);

            string[] titles = items.Select(x => x.Title).ToArray();


            listViewToDo.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, titles);
        }
    }
}