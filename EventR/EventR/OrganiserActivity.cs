using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;

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

            // TODO: instead of using this array we should be using the hostedEvents list
            string[] appointmentsArray = Resources.GetStringArray(Resource.Array.appointments);
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, appointmentsArray);
        }
    }
}

