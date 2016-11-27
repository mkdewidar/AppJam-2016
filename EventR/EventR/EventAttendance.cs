using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EventR
{
    [Activity(Label = "EventAttendance")]
    public class EventAttendance : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EventAttendence);

            Button b = FindViewById<Button>(Resource.Id.button1);

            bool boolVar1 = false;
            b.Text = "get help";

            //Fill array "attendingArray" with the content from "attending" string-array from Strings.xml
            string[] attendingArray = Resources.GetStringArray(Resource.Array.attending);
            //Adapt the content of "attendingArray" to be displayed as a "SimpleListItem1" in the display
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, attendingArray);

            b.Click += delegate {
                if (boolVar1)
                {
                    attendingArray = Resources.GetStringArray(Resource.Array.attending);
                    b.Text = "Attending";
                    boolVar1 = !boolVar1;
                }
                else
                {
                    attendingArray = Resources.GetStringArray(Resource.Array.not_attending);
                    b.Text = "Not Attending";
                    boolVar1 = !boolVar1;
                }
                
                ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, attendingArray);
            };
        }
    }
}