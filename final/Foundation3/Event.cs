using System;

class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public TimeSpan Time
    {
        get { return time; }
        set { time = value; }
    }

    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        string details = "Standard Details:\n";
        details += $"Title: {Title}\n";
        details += $"Description: {Description}\n";
        details += $"Date: {Date.ToShortDateString()}\n";
        details += $"Time: {Time.ToString(@"hh\:mm")}\n";
        details += $"Address:\n{Address.GetFormattedAddress()}";
        return details;
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
