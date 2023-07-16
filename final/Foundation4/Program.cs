using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(DateTime.Now, 30, 3.0);
        activities.Add(running);

        StationaryBicycle stationaryBicycle = new StationaryBicycle(DateTime.Now, 45, 10.0);
        activities.Add(stationaryBicycle);

        Swimming swimming = new Swimming(DateTime.Now, 40, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
