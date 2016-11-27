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
    [Activity(Label = "Event Attendance")]
    public class EventAttendance : ListActivity
    {
        private List<Attendee> invitedPeople = new List<Attendee>();
        private bool peopleAttending = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EventAttendence);

            // mode being the "showing people attending" or "showing people not attending"
            Button changeMode = FindViewById<Button>(Resource.Id.button1);

            changeMode.Text = "Attending";

            string eventName = Intent.GetStringExtra("EVENT_NAME");
            int eventIndex = 0;
            for (int i = 0; i < MainActivity.events.Count; i++)
            {
                if (MainActivity.events[i].name == eventName)
                {
                    eventIndex = i;
                    break;
                }
            }

            foreach (var person in MainActivity.events[eventIndex].attendees)
            {
                if (person.isAttending == peopleAttending)
                {
                    invitedPeople.Add(person);
                }
            }

            //Adapt the content of "attendingArray" to be displayed as a "SimpleListItem1" in the display
            ListAdapter = new ArrayAdapter<Attendee>(this, Android.Resource.Layout.SimpleListItem1, invitedPeople);

            changeMode.Click += delegate {
                // if you are showing the people that are attending then show the other ones
                // otherwise make a list of those who are attending (effectivly switching between the two on click)
                peopleAttending = !peopleAttending;
                if (peopleAttending)
                {
                    invitedPeople = new List<Attendee>();
                    foreach (var person in MainActivity.events[eventIndex].attendees)
                    {
                        if (person.isAttending == peopleAttending)
                        {
                            invitedPeople.Add(person);
                        }
                    }
                    changeMode.Text = "Attending";
                    
                }
                else
                {
                    invitedPeople = new List<Attendee>();
                    foreach (var person in MainActivity.events[eventIndex].attendees)
                    {
                        if (person.isAttending == peopleAttending)
                        {
                            invitedPeople.Add(person);
                        }
                    }
                    changeMode.Text = "Not Attending";
                }
                ListAdapter = new ArrayAdapter<Attendee>(this, Android.Resource.Layout.SimpleListItem1, invitedPeople);
            };
        }
    }
}