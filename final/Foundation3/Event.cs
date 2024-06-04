using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() => _title;
    public string GetDescription() => _description;
    public string GetDate() => _date;
    public string GetTime() => _time;
    public Address GetAddress() => _address;

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
}