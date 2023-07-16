using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Eat With A Fork", "Ashley", 120);
        video1.AddComment("RipleHeart", "Great video!");
        video1.AddComment("TechnaPrincess", "I learned a lot from this.");
        videos.Add(video1);

        Video video2 = new Video("World Of WarCraft Top 5", "Kyle", 180);
        video2.AddComment("RougeSteel", "Awesome content!");
        video2.AddComment("LyleFields", "Could you explain more about XYZ?");
        videos.Add(video2);

        Video video3 = new Video("Cringe Isekai Premises Done Badly", "Chantal", 240);
        video3.AddComment("Beryl05", "This is really helpful.");
        video3.AddComment("Ms.Arbor", "I have a question regarding the topic.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("  Comment by " + comment._name + ": " + comment._text);
            }
            Console.WriteLine();
        }
    }
}