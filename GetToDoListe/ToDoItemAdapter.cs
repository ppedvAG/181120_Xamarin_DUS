using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GetToDoListe
{
    class ToDoItemAdapter : BaseAdapter<ToDoItem>
    {
        public ToDoItemAdapter(Activity context, ToDoItem[] items)
        {
            this.context = context;
            this.items = items;
        }
        private Activity context;
        private ToDoItem[] items;

        public override ToDoItem this[int position] => items[position];

        public override int Count => items.Length;

        public override long GetItemId(int position)
        {
            return items[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // 1) listViewItem erstellen basierend auf einem layout
            // 2) item mit daten füllen
            // 3) item der listview hinzufügen (return)

            View v = context.LayoutInflater.Inflate(Resource.Layout.todoitemlayout, parent, false);

            var id = v.FindViewById<TextView>(Resource.Id.textViewID);
            var title = v.FindViewById<TextView>(Resource.Id.textViewTitle);

            id.Text = items[position].Id.ToString();
            title.Text = items[position].Title.ToString();

            return v;
        }
    }
}