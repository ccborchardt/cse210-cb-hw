using System;

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public string Speaker
    {
        get { return speaker; }
        set { speaker = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details += $"\nType: {GetType().Name}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        return details;
    }
}