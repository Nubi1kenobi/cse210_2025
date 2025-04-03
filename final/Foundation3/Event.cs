using System;
public class Event
{
    private string _eventType = "Default Event";
    private string _title = "Default Event";
    private string _description = "Default Description";
    private string _date = "01JAN25";
    private string _time = "5:00 PM";
    private string _fullDetails = "defaul full details";
    private Address _eventAddress;
    public Event(string eventTitle, string  eventDesc, string  eventDate, string eventTime, string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        SetEvent(eventTitle, eventDesc, eventDate, eventTime);
        SetAddress(streetAddress, city, state_Province, zipCode, country);        
    }

    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }
    public void SetEvent(string eventTitle, string  eventDesc, string  eventDate, string eventTime)
    {
        _title = eventTitle;
        _description = eventDesc;
        _date = eventDate;
        _time = eventTime;
    }
    public void SetAddress(string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        _eventAddress.SetAddress(streetAddress, city, state_Province, zipCode, country);
    }
    public void SetFullDetails(string additionalDetails)
    {
        _fullDetails = additionalDetails;
    }
    public string StandardDetails()
    {
        return $"{_title} - {_description} - {_date} - {_time}\n{_eventAddress.GetAddress()}";
    }
    public string GetFullDetails(string fullDetails)
    {
        return $"{_eventType} - {StandardDetails()}\n{fullDetails}";
    }
    public string ShortDesc()
    {
        return $"{_eventType} - {_title} - {_date}";
    }
    
} 