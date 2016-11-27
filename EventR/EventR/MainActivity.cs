using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace EventR
{
    [Activity(Label = "EventR",MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static public List<ScheduledEvent> events = new List<ScheduledEvent>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            PopulateEvents();

            Button userButton = FindViewById<Button>(Resource.Id.user1_button_id);

            userButton.Click += delegate
            {
                StartActivity(typeof(OrganiserActivity));
            };

            userButton.Text = "Click here to be User 1!!";
		}

        private void PopulateEvents()
        {
            events.Add(new ScheduledEvent());
            events[0].name = "Christmas Party";
            events[0].amHosting = true;
            events[0].attendees = new List<Attendee>();
            events[0].attendees.Add(new Attendee("Victor", true, true));
            events[0].attendees.Add(new Attendee("Mo",false,false));
            events[0].attendees.Add(new Attendee("Matt", false, true));

            events.Add(new ScheduledEvent());
            events[1].name = "Ice Skating";
            events[1].amHosting = false;
            events[1].attendees = new List<Attendee>();
            events[1].attendees.Add(new Attendee("Jim", true, true));
            events[1].attendees.Add(new Attendee("Fred", false, false));
            events[1].attendees.Add(new Attendee("Garret", false, true));
            events[1].attendees.Add(new Attendee("Gary", true, true));

            events.Add(new ScheduledEvent());
            events[2].name = "AppJam";
            events[2].amHosting = true;
            events[2].attendees = new List<Attendee>();
            events[2].attendees.Add(new Attendee("Annie", true, true));
            events[2].attendees.Add(new Attendee("Alex", false, false));
            events[2].attendees.Add(new Attendee("Ross", false, true));
            events[2].attendees.Add(new Attendee("David", true, true));

            events.Add(new ScheduledEvent());
            events[3].name = "Spoons";
            events[3].amHosting = false;
            events[3].attendees = new List<Attendee>();
            events[3].attendees.Add(new Attendee("John", true, true));
            events[3].attendees.Add(new Attendee("Mark", false, false));
            events[3].attendees.Add(new Attendee("Brad", false, true));
            events[3].attendees.Add(new Attendee("Josh", true, true));
        }
    }

    enum UserIDs
    {
        User1,
        User2
    }
}
