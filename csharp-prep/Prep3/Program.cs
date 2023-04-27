using System;

class Program
{
    static void Main(string[] args)
    {
        // Commented out code
        // Console.Write("What is the Magic Number? ");
        // int MasterNum = int.Parse(Console.ReadLine());
        
        // Randomly Genertated Master Guess Number
        Random randomGenerator = new Random();
        int MasterNum = randomGenerator.Next(1, 101);
        // Constant for the loop
        int input = 0; 

        // The loop in question
        // It is what lets the user to actually play the game
        // It checks to see how close their guess is.
        do
        {
            Console.Write("What is your guess? ");
            input = int.Parse(Console.ReadLine());

            if (MasterNum > input)
            {
                Console.WriteLine("Higher");
            }
            else if (MasterNum < input)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


        }while (input != MasterNum);
    }
}