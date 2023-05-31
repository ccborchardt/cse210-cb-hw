using System;
using System.Collections.Generic;
using System.IO;
namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Scripture scripture = new Scripture();


            while (!scripture.AllWordsHidden())
            {
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
                Console.WriteLine();
                Console.WriteLine(scripture.GetFormattedText());
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    break;
                }

                scripture.HideWords(2);
                Console.Clear();
            }
        }
    }
}
