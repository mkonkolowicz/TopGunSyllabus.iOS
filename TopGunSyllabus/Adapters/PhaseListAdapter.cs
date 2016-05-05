using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using TopGunSyllabus.Core.Model;

namespace TopGunSyllabus.Android.Adapters
{
    public class PhaseListAdapter: BaseAdapter<Phase>
    {
        private List<Phase> items;
        private Activity context;

        public PhaseListAdapter(Activity context, List<Phase> items ) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Phase this [int position]
        {
            get
            {
                return items[position]; 
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(global::Android.Resource.Layout.SimpleListItem1, null);
            }
            convertView.FindViewById<TextView>(global::Android.Resource.Id.Text1).Text =
                item.Name;
            return convertView;
        }
    }
}