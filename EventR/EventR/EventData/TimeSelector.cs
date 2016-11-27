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

namespace EventR.EventData
{
    [Activity(Label = "TimeSelector",MainLauncher =true)]
    public class TimeSelector : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            EventDate event1 = new EventDate();
            event1.startDate = new DateTime(2016, 12, 3, 15, 0, 0, 0);
            event1.duration = 60;

            EventDate event2 = new EventDate();
            event2.startDate = new DateTime(2016, 11, 2, 18, 0, 0, 0);
            event2.duration = 120;

            EventDate event3 = new EventDate();
            event2.startDate = new DateTime(2016, 12, 16, 16, 0, 0, 0);
            event3.duration = 90;
 
            EventDate[] events = { event1,event2,event3 };
            string[] histring = { "hi", "hi", "hi" };
            ListAdapter = new EventDateAdapter(this, events);
        }
    }
}