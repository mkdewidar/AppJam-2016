using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Content;

using System.Collections.Generic;

namespace EventR
{
    [Activity(Label = "Scheduled Events")]
    public class GuestActivity : ListActivity
    {
        private List<ScheduledEvent> scheduledEvents = new List<ScheduledEvent>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            foreach (var e in MainActivity.events)
            {
                for (int i = 0; i < e.attendees.Count; i++)
                {
                string tempname = e.attendees[i].name;
                if (MainActivity.userName == tempname)
                {
                    scheduledEvents.Add(e);
                }
                }
            }


            // scheduledEvents.Add(new ScheduledEvent() { name = "Event1" } );
            // scheduledEvents.Add(new ScheduledEvent() { name = "Event2" } );

            ListAdapter = new ArrayAdapter<ScheduledEvent>(this, Android.Resource.Layout.SimpleListItem1, scheduledEvents);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            // we're passing the index of the event to the time selector to show its dates
            Intent openTimeSelector = new Intent(this, typeof(TimeSelector));
            openTimeSelector.PutExtra("EVENT_NAME", scheduledEvents[position].name);
            StartActivity(openTimeSelector);
        }
    }
}