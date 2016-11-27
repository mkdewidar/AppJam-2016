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

            // TODO: This is where you get to set all the data for the events
            PopulateEvents();

            Button userButton = FindViewById<Button>(Resource.Id.user1_button_id);

            userButton.Click += delegate
            {
                StartActivity(typeof(GuestActivity));
            };

            userButton.Text = "Click here to be User 1!!";
		}

        private void PopulateEvents()
        {
            // TODO: use this function to populate all of the event data
        }
    }

    enum UserIDs
    {
        User1,
        User2
    }
}
