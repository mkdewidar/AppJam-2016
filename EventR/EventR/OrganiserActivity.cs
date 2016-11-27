using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using Android.Views;
using Android.Content;

using System.Collections.Generic;

namespace EventR
{
    [Activity(Label = "Hosted Events")]
    public class OrganiserActivity : ListActivity
    {
        private List<ScheduledEvent> hostedEvents = new List<ScheduledEvent>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            foreach (var e in MainActivity.events)
            {
                if (e.amHosting == true)
                {
                    hostedEvents.Add(e);
                }
            }

            ListAdapter = new ArrayAdapter<ScheduledEvent>(this, Android.Resource.Layout.SimpleListItem1, hostedEvents);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Intent openEventAttendance = new Intent(this, typeof(EventAttendance));
            openEventAttendance.PutExtra("EVENT_NAME", hostedEvents[position].name);
            StartActivityForResult(openEventAttendance, -1);
        }

    }
}

