using System;
public class Reception : Event 
{
    private string _rsvp = "";
    public Reception(string eventTitle, string  eventDesc, string  eventDate, string eventTime, string streetAddress, string city, string state_Province, string zipCode, string country, string details, string eventType, string rsvp) : base(eventTitle, eventDesc, eventDate, eventTime, streetAddress, city, state_Province, zipCode, country)
    {
        SetEventType(eventType);
        SetRSVP(rsvp);
        string detailString = SetDetailsString(details, rsvp);
        SetFullDetails(detailString);
    }
    public void SetRSVP(string rsvp)
    {
        _rsvp = rsvp;
    }
    public string SetDetailsString(string details, string rsvp)
    {
        return $"\n{details}\n{rsvp}.";
    }
}