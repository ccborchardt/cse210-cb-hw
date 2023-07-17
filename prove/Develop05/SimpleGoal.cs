using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int value) : base(description, value) { }

    public override void Complete()
    {
        Console.WriteLine($"Completed goal: {description}");
        Console.WriteLine($"Gained {value} points");
    }

    public override string Progress()
    {
        return "[ ]";
    }
}