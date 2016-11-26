using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;

namespace EventR
{
    [Activity(Label = "EventR", MainLauncher = true, Icon = "@drawable/icon")]
    public class OrganiserActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            
            string[] appointmentsArray = Resources.GetStringArray(Resource.Array.appointments);
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, appointmentsArray);

        }
    }
}

