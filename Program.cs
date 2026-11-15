using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Jollof Rice", "Chef Amara", 600);
        video1.AddComment(new Comment("Tunde", "This is the best jollof recipe I have ever seen!"));
        video1.AddComment(new Comment("Chioma", "I tried it yesterday, my family loved it."));
        video1.AddComment(new Comment("Emeka", "Please do a video on fried rice next."));
        videos.Add(video1);

        Video video2 = new Video("Learn C# in 10 Minutes", "Code With David", 620);
        video2.AddComment(new Comment("Sarah", "Finally someone explained classes clearly."));
        video2.AddComment(new Comment("John", "This helped me pass my assignment, thank you!"));
        video2.AddComment(new Comment("Mary", "Can you do a video on lists next?"));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Places to Visit in Lagos", "Travel Naija", 900);
        video3.AddComment(new Comment("Ada", "Lekki Conservation Centre is my favorite!"));
        video3.AddComment(new Comment("Kunle", "You forgot to add Nike Art Gallery."));
        video3.AddComment(new Comment("Funke", "I am visiting Lagos next month, this helps a lot."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
