using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.Collections.Generic;

namespace EventR
{
    [Activity(Label = "EventR",MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static public List<ScheduledEvent> events = new List<ScheduledEvent>();
        static public string userName;

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

            userButton.Text = "Events you are hosting";

            Button user2Button = FindViewById<Button>(Resource.Id.user2_button_id);

            user2Button.Click += delegate
            {
                StartActivity(typeof(GuestActivity));
            };
            user2Button.Text = "Events you have been invited to";

            EditText namebox = FindViewById<EditText>(Resource.Id.editText1);


            namebox.KeyPress += (object sender,  View.KeyEventArgs e) => {
                e.Handled = false;
                if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                {
                    userName = namebox.Text;
                    Toast.MakeText(this, namebox.Text, ToastLength.Short).Show();
                    e.Handled = true;
                }
            };

            TextView namecopy = FindViewById<TextView>(Resource.Id.textView1);
            namecopy.Text = userName;
		}

        private void PopulateEvents()
        {
            events.Add(new ScheduledEvent());
            events[0].name = "Christmas Party";
            events[0].HostName = "Matt";
            events[0].attendees = new List<Attendee>();
            events[0].attendees.Add(new Attendee("Victor", true, true));
            events[0].attendees.Add(new Attendee("Mo",false,false));
            events[0].attendees.Add(new Attendee("Matt", false, true));
            events[0].dates = new List<EventDate>();
            events[0].dates.Add(new EventDate() { duration = 200, startDate = new System.DateTime(2016, 12, 2, 14, 00, 00) });
            events[0].dates.Add(new EventDate() { duration = 200, startDate = new System.DateTime(2016, 10, 15, 14, 00, 00) });
            events[0].dates.Add(new EventDate() { duration = 200, startDate = new System.DateTime(2016, 9, 2, 14, 00, 00) });

            events.Add(new ScheduledEvent());
            events[1].name = "Ice Skating";
            events[1].HostName = "Victor";
            events[1].attendees = new List<Attendee>();
            events[1].attendees.Add(new Attendee("Jim", true, true));
            events[1].attendees.Add(new Attendee("Fred", false, false));
            events[1].attendees.Add(new Attendee("Garret", false, true));
            events[1].attendees.Add(new Attendee("Gary", true, true));
            events[1].dates = new List<EventDate>();
            events[1].dates.Add(new EventDate() { duration = 500, startDate = new System.DateTime(2017, 1, 2, 15, 30, 00) });
            events[1].dates.Add(new EventDate() { duration = 500, startDate = new System.DateTime(2017, 2, 7, 15, 30, 00) });
            events[1].dates.Add(new EventDate() { duration = 500, startDate = new System.DateTime(2016, 12, 12, 10, 30, 00) });
            events[1].dates.Add(new EventDate() { duration = 500, startDate = new System.DateTime(2017, 2, 16, 10, 30, 00) });

            events.Add(new ScheduledEvent());
            events[2].name = "AppJam";
            events[2].HostName = "Mo";
            events[2].attendees = new List<Attendee>();
            events[2].attendees.Add(new Attendee("Annie", true, true));
            events[2].attendees.Add(new Attendee("Alex", false, false));
            events[2].attendees.Add(new Attendee("Ross", false, true));
            events[2].attendees.Add(new Attendee("David", true, true));
            events[2].dates = new List<EventDate>();
            events[2].dates.Add(new EventDate() { duration = 1440, startDate = new System.DateTime(2016, 11, 27, 12, 00, 00) });
            events[2].dates.Add(new EventDate() { duration = 1440, startDate = new System.DateTime(2016, 12, 2, 12, 00, 00) });

            events.Add(new ScheduledEvent());
            events[3].name = "Spoons";
            events[3].HostName = "John";
            events[3].attendees = new List<Attendee>();
            events[3].attendees.Add(new Attendee("John", true, true));
            events[3].attendees.Add(new Attendee("Mark", false, false));
            events[3].attendees.Add(new Attendee("Brad", false, true));
            events[3].attendees.Add(new Attendee("Josh", true, true));
            events[3].dates = new List<EventDate>();
            events[3].dates.Add(new EventDate() { duration = 90, startDate = new System.DateTime(2016, 12, 10, 13, 00, 00) });
            events[3].dates.Add(new EventDate() { duration = 90, startDate = new System.DateTime(2016, 12, 10, 15, 00, 00) });

            events.Add(new ScheduledEvent());
            events[4].name = "New Year Light Show";
            events[4].HostName = "John";
            events[4].attendees = new List<Attendee>();
            events[4].attendees.Add(new Attendee("Annie", true, true));
            events[4].attendees.Add(new Attendee("Brad", false, false));
            events[4].attendees.Add(new Attendee("David", false, true));
            events[4].attendees.Add(new Attendee("Alex", true, true));
            events[4].dates = new List<EventDate>();
            events[4].dates.Add(new EventDate() { duration = 90, startDate = new System.DateTime(2016, 12, 10, 13, 00, 00) });
            events[4].dates.Add(new EventDate() { duration = 90, startDate = new System.DateTime(2016, 12, 10, 15, 00, 00) });

            events.Add(new ScheduledEvent());
            events[5].name = "New Year Light Show";
            events[5].HostName = "John";
            events[5].attendees = new List<Attendee>();
            events[5].attendees.Add(new Attendee("Annie", true, true));
            events[5].attendees.Add(new Attendee("Brad", false, false));
            events[5].attendees.Add(new Attendee("David", false, true));
            events[5].attendees.Add(new Attendee("Alex", true, true));
            events[5].dates = new List<EventDate>();
            events[5].dates.Add(new EventDate() { duration = 120, startDate = new System.DateTime(2016, 11, 30, 13, 00, 00) });
            events[5].dates.Add(new EventDate() { duration = 120, startDate = new System.DateTime(2016, 11, 30, 15, 00, 00) });
            events[5].dates.Add(new EventDate() { duration = 120, startDate = new System.DateTime(2016, 12, 1, 10, 00, 00) });
            events[5].dates.Add(new EventDate() { duration = 120, startDate = new System.DateTime(2016, 12, 1, 12, 00, 00) });
        }
    }

    enum UserIDs
    {
        User1,
        User2
    }
}
