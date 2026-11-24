using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C# in 10 Minutes", "CodeWithAna", 600);
        video1.AddComment(new Comment("Carlos", "Very clear explanation!"));
        video1.AddComment(new Comment("Maria", "Finally understood classes."));
        video1.AddComment(new Comment("John", "Please make a part 2."));

        Video video2 = new Video("Easy Ceviche Recipe", "Cocina Peruana", 480);
        video2.AddComment(new Comment("Lucia", "Tastes just like home."));
        video2.AddComment(new Comment("Pedro", "I added extra aji, so good!"));
        video2.AddComment(new Comment("Sara", "Great tips on the lime juice."));
        video2.AddComment(new Comment("Mike", "Making this tonight."));

        Video video3 = new Video("Top 5 Retro Games", "RetroPlayer", 900);
        video3.AddComment(new Comment("Alex", "Number 3 was my childhood."));
        video3.AddComment(new Comment("Emma", "Love the old soundtracks."));
        video3.AddComment(new Comment("Luis", "You forgot Zelda!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}