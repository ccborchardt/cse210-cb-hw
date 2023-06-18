using System;
using System.Threading;

namespace Develop04
{
    class Breathe : Activity
    {
        public Breathe() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void PerformActivity(int duration)
        {
            int count = 0;
            while (count < duration)
            {
                if (count % 2 == 0)
                    {
                        Console.WriteLine("Breathe in...");
                        Console.WriteLine(" ");
                    }

                else
                    {
                        Console.WriteLine("Breathe out...");
                        Console.WriteLine(" ");
                    }

                count++;
                Thread.Sleep(1000);
            }
        }
    }
}