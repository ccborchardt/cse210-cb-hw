using System;

class Outdoor : Event
{
    private string weatherStatement;

    public string WeatherStatement
    {
        get { return weatherStatement; }
        set { weatherStatement = value; }
    }

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        WeatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details += $"\nType: {GetType().Name}\nWeather Statement: {WeatherStatement}";
        return details;
    }
}