using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Code in C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you do a video on classes?"));
        videos.Add(video1);

        Video video2 = new Video("Cooking Pasta", "Jane Smith", 900);
        video2.AddComment(new Comment("Dave", "Love this recipe!"));
        video2.AddComment(new Comment("Eve", "Tried it, and it was delicious!"));
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog: Japan", "Alex Brown", 1200);
        video3.AddComment(new Comment("Frank", "Amazing places!"));
        video3.AddComment(new Comment("Grace", "Japan is on my bucket list!"));
        video3.AddComment(new Comment("Hank", "Nice video quality."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}