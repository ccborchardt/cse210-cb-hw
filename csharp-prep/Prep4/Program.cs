using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        int constant = -1;

        while(constant != 0)
        {
            Console.Write("Enter a number: ");
            
            string input = Console.ReadLine();
            constant = int.Parse(input);
            
            if (constant != 0)
            {
                numbers.Add(constant);
            }
        }

        int sum = 0;
        foreach (int i in numbers)
        {
            sum = sum + i;
        }

        Console.WriteLine($"The sum: {sum}");

        float listavg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {listavg}");

        int listmax = numbers[0];
         foreach (int i in numbers)
        {
            if (i > listmax)
            {
                listmax = i;
            }
        }

        Console.WriteLine($"The max is: {listmax}"); 
    }
}