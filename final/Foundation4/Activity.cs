using System;
using System.Collections.Generic;
class Activity
{
    private DateTime _date;
    private int _length;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public Activity(DateTime date, int length)
    {
        Date = date;
        Length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}