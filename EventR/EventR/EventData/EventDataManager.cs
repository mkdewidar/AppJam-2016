using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EventR
{
    class EventDataManager
    {
        static List<ScheduledEvent> GetEventData()
        {
            List<ScheduledEvent> events = new List<ScheduledEvent>();

            using (StreamReader r = new StreamReader("EventData.json"))
            {
                string json = r.ReadToEnd();
            }

            return events;
        }
    }
}