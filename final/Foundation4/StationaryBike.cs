using System;
using System.Collections.Generic;

class StationaryBicycle : Activity
{
    private double _speed;

    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public StationaryBicycle(DateTime date, int length, double speed)
        : base(date, length)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Stationary Bicycle ({Length} min) - Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}