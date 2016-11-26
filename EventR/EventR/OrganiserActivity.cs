using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;

namespace EventR
{
    [Activity(Label = "OrganiserActivity")]
    public class OrganiserActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            string[] appointmentsArray = Resources.GetStringArray(Resource.Array.appointments);
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, appointmentsArray);
        }
    }
}

