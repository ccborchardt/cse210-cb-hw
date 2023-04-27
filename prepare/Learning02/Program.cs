using System;

namespace Learning02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning02 World!");
            Learning02.Program p = new Learning02.Program();
           
        }
    }
}

public class Program1 
{
    public void DoSome()
    {
        Console.WriteLine("How I'm inside the other program class.");
    }
}