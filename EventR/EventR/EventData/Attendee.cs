
namespace EventR
{
    public class Attendee
    {
        public string name;
        public bool isAttending;
        public bool confirmed;

        public  Attendee(string attendeeName, bool willAttend, bool decided)
        {
            this.name = attendeeName;
            this.confirmed = decided;
            this.isAttending = willAttend;
        }

        public override string ToString()
        {
            return name;
        }
    }
}