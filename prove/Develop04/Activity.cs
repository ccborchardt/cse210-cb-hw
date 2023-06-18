using System;
using System.Threading;

namespace Develop04
{
    abstract class Activity
    {
        public string Name { get; }
        public string Description { get; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Starting {Name} activity...");
            Console.WriteLine(Description);
            Console.WriteLine(" ");
            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Prepare to begin...");
            Console.WriteLine(" ");
            Thread.Sleep(3000);

            PerformActivity(duration);

            Console.WriteLine("Good job! You have completed the activity.");
            Console.WriteLine($"Activity: {Name}");
            Console.WriteLine($"Duration: {duration} seconds");
            Thread.Sleep(3000);
        }

        protected abstract void PerformActivity(int duration);
    }

}