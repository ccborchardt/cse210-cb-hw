using System;
using System.IO;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Entry myEntry = new Entry();
        Journal journal = new Journal();
        journal.StoreEntry(myEntry);
        List<Entry> entries = journal.GetEntries();

        Save save = new Save();


        bool loop = false;

        while (loop == false)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do?");
            int input = Convert.ToInt32(Console.ReadLine());

            

            if (input == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                myEntry.Pick(myEntry.Prompts());
                
                Console.Write("Entry: ");
                string attempt = Console.ReadLine();
                
                
                journal.StoreEntry(myEntry);


            }
            else if (input == 2)
            {
                journal.DisplayEntries();
            }
            else if (input == 3)
            {
                save.Filelist();

                Console.WriteLine("Please enter a filename from the above list.");
                Console.Write("File Name: ");
                string flist = Console.ReadLine();
                save.csvDisplay(flist);
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                myEntry.Pick(myEntry.Prompts());
                
                Console.Write("Entry: ");
                string attempt = Console.ReadLine();
                
                
                journal.StoreEntry(myEntry);
            }
            else if (input == 4)
            {
                Console.WriteLine("Please enter the name of the new file below.");
                Console.WriteLine("It needs to end with '.txt' to work");
                Console.Write("File Name: ");
                string fName = Console.ReadLine();
                save.saveFile(fName, entries); 
            }
            else if (input == 5)
            {
                loop = true;
                
            }
    

        }

        }
    }
}
