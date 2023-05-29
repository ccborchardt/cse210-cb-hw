using System;
using System.Collections.Generic;
using System.IO;
namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");


            while (!scripture.AllWordsHidden())
            {
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
