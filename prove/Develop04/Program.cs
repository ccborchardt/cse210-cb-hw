using System;


namespace Develop04
{
        public class Program
    {
        static void Main(string[] args)
        {
            Activity[] activities = { new Breathe(), new Reflection(), new GoodList() };

            while (true)
            {
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Activity activity = activities[0];
                    activity.Start(); 
                }
                else if (choice == 2)
                {
                    Activity activity = activities[1];
                    activity.Start();
                }
                else if (choice == 3)
                {
                    Activity activity = activities[2];
                    activity.Start();
                }
                else if (choice == 4)
                    break;

                else if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }
            }
        }
    }
}
