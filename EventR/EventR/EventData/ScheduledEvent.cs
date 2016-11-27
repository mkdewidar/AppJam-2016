using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventR
{
    public class ScheduledEvent
    {
        public string name;
        public List<EventDate> dates;
        public List<Attendee> attendees;
        public bool amHosting;

        public override string ToString()
        {
            return name;
        }
    }
}