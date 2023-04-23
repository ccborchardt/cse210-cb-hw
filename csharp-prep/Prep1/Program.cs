using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string cbfirst = Console.ReadLine();

        Console.Write("What is your last name? ");
        string cblast = Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine($"Your name is {cblast}, {cbfirst} {cblast}. ");
    }
}