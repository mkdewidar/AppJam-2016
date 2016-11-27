using Android.App;
using Android.OS;
using Android.Widget;

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
                if (e.amHosting == false)
                {
                    scheduledEvents.Add(e);
                }
            }

            // scheduledEvents.Add(new ScheduledEvent() { name = "Event1" } );
            // scheduledEvents.Add(new ScheduledEvent() { name = "Event2" } );

            ListAdapter = new ArrayAdapter<ScheduledEvent>(this, Android.Resource.Layout.SimpleListItem1, scheduledEvents);
        }
    }
}