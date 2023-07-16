using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "San Francisco", "CA", "USA");
        Address address3 = new Address("789 Oak St", "Chicago", "IL", "USA");

        Event event1 = new Event("The Event", "We don't know what is going to happen here.", new DateTime(2023, 10, 15), new TimeSpan(14, 0, 0), address1);
        Lecture lecture = new Lecture("College Lecture", "Lecture on the Bronze Age Collapse", new DateTime(2023, 11, 20), new TimeSpan(18, 30, 0), address2, "John Doe", 50);
        Reception reception = new Reception("Wedding Reception", "Come Celebrate the Happy Union of the Bride and Groom",new DateTime(2023, 10, 20), new TimeSpan(11, 0, 0), address3, "rsvp@happyunion.com");
        Outdoor outdoorGathering = new Outdoor("Outdoor Concert", "Our main attraction is Nickelback!",new DateTime(2023, 9, 5), new TimeSpan(12, 0, 0), address1, "Sunny");


        Console.WriteLine("The Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("College Lecture:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Wedding Reception:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Concert:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}