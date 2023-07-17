using System;
using System.Collections.Generic;


public class EternalGoal : Goal
{
    private int completionCount;

    public EternalGoal(string description, int value) : base(description, value)
    {
        completionCount = 0;
    }

    public override void Complete()
    {
        completionCount++;
        Console.WriteLine($"Recorded goal: {description}");
        Console.WriteLine($"Gained {value} points");
    }

    public override string Progress()
    {
        return $"Completed {completionCount} times";
    }
}
