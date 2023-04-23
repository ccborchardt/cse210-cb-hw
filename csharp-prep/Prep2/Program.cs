using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int p = int.Parse(grade);

        string letter = "";

        if (p >= 90)
        {
            letter = "A";
        }
        else if (p >= 80)
        {
            letter = "B";
        }
        else if (p >= 70)
        {
            letter = "C";
        }
        else if (p >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Letter Grade: {letter}");
        
    }
}