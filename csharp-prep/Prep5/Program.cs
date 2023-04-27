using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserAge = PromptUserNumber();
        int SquareNum = SquareNumber(UserAge);
        DisplayResult(UserName, SquareNum);
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        return age;
    } 
    static int SquareNumber(int age)
    {
        int square = age * age; 

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}!");
    }
}