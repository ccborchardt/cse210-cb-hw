using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    class GoodList: Activity
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public GoodList() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void PerformActivity(int duration)
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(3000);

            Console.WriteLine(" ");

            Console.WriteLine("Begin listing:");
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;

            while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
            {
                string item = Console.ReadLine();
                items.Add(item);
            }

            Console.WriteLine($"Number of items listed: {items.Count}");
            Console.WriteLine(" ");
        }
    }
}