using System;
using System.Collections.Generic;

class Running : Activity
{
    private double _distance;

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Length * 60;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Length} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}