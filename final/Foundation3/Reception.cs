using System;

class Reception : Event
{
    private string rsvpEmail;

    public string RsvpEmail
    {
        get { return rsvpEmail; }
        set { rsvpEmail = value; }
    }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details += $"\nType: {GetType().Name}\nRSVP Email: {RsvpEmail}";
        return details;
    }
}