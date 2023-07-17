using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();

    public static void Main(string[] args)
    {
        // Create some goals
        Goal goal1 = new SimpleGoal("Run a marathon", 1000);
        Goal goal2 = new EternalGoal("Read the scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend the temple", 50, 10);

        // Add goals to the list
        goals.Add(goal1);
        goals.Add(goal2);
        goals.Add(goal3);

        // Simulate completing goals
        goal1.Complete();
        goal2.Complete();
        goal3.Complete();
        goal3.Complete();
        goal3.Complete();

        // Display the user's score and goals
        Console.WriteLine();
        Console.WriteLine("Current Score:");
        int totalScore = 0;
        foreach (Goal goal in goals)
        {
            totalScore += goal.value;
            Console.WriteLine($"{goal.Progress()} - {goal.description}");
        }
        Console.WriteLine($"Total Score: {totalScore}");

        // Save and load goals
        SaveGoals();
        LoadGoals();
    }

    public static void SaveGoals()
    {
        // Save goals implementation
        Console.WriteLine("Goals saved.");
    }

    public static void LoadGoals()
    {
        // Load goals implementation
        Console.WriteLine("Goals loaded.");
    }
}