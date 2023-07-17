using System;
using System.Collections.Generic;


public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completionCount;

    public ChecklistGoal(string description, int value, int targetCount) : base(description, value)
    {
        this.targetCount = targetCount;
        completionCount = 0;
    }

    public override void Complete()
    {
        completionCount++;
        Console.WriteLine($"Recorded goal: {description}");
        Console.WriteLine($"Gained {value} points");
        
        if (completionCount == targetCount)
        {
            int bonus = 500;
            Console.WriteLine($"Bonus: Gained {bonus} points for completing the goal {targetCount} times");
        }
    }

    public override string Progress()
    {
        return $"Completed {completionCount}/{targetCount} times";
    }
}