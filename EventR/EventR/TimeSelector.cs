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
    [Activity(Label = "Possible Dates")]
    public class TimeSelector : ListActivity
    {
        private List<EventDate> possibleDates = new List<EventDate>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TimeSelectionLayout);

            string eventName = Intent.GetStringExtra("EVENT_NAME");
            int eventIndex = 0;
            for (int count = 0; count < MainActivity.events.Count; count++)
            {
                if (MainActivity.events[count].name == eventName)
                {
                    eventIndex = count;
                    break;
                }
            }
            possibleDates = MainActivity.events[eventIndex].dates;
            ListAdapter = new EventDateAdapter(this, possibleDates);
        }
    }
}