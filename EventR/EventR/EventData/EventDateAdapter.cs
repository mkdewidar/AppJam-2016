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

namespace EventR
{
   public class EventDateAdapter :BaseAdapter<string>
    {
        Activity _context;
        EventDate[] eventsss_;
        public EventDateAdapter(Activity context, EventDate[] eventsss) :base()
        {
            this._context = context;
            this.eventsss_ = eventsss;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override string this[int position]
        {
            get
            {
                return eventsss_.ToString();
            }
        }
        public override int Count
        {
            get
            {
               return eventsss_.Length; 
            }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            view = _context.LayoutInflater.Inflate(Resource.Layout.ScheduledEventListItem, null);
            // view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = eventsss_[position];
            return view;
        }
    }
}