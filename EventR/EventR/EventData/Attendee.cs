
namespace EventR
{
    public class Attendee
    {
        public string name;
        public bool isAttending;
        public bool confirmed;

        Attendee(string attendeeName, bool willAttend, bool decided)
        {
            this.name = attendeeName;
            this.confirmed = decided;
            this.isAttending = willAttend;
        }
    }
}