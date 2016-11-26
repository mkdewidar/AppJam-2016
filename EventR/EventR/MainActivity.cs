using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;

namespace EventR
{
    [Activity(Label = "EventR", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button userButton = FindViewById<Button>(Resource.Id.user1_button_id);

            userButton.Click += delegate
            {
                StartActivity(typeof(OrganiserActivity));
            };

            userButton.Text = "Click here to be User 1!!";
		}
    }

    enum UserIDs
    {
        User1,
        User2
    }
}
