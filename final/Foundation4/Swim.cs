using System;
using System.Collections.Generic;
class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Length * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}