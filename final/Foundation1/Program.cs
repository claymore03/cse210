using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Rating the Best Water", "Chris", 360);
        video1.AddComment(new Comment("Ashly", "I love Fiji water!"));
        video1.AddComment(new Comment("Brad", "Dasani is garbage water."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Games 2020", "GamerBro", 600);
        video2.AddComment(new Comment("Dani", "Great list!"));
        video2.AddComment(new Comment("Ethan", "Where was the Last of Us: Part II?"));
        video2.AddComment(new Comment("Fernando", "Days Gone is a masterpiece!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Will it Cake?", "Cakemaster 3000", 960);
        video3.AddComment(new Comment("Sandy", "Yum! Your cake looks delicious."));
        video3.AddComment(new Comment("Patrick", "I can't believe ranch makes good cake."));
        video3.AddComment(new Comment("Eugene", "Two thumbs up!"));
        video3.AddComment(new Comment("Bob", "MAke a pineapple upside-down cake next!"));
        video3.AddComment(new Comment("Ward", "Are you a moron?"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Coding 4 Dummies", "Coding Guru", 500);
        video4.AddComment(new Comment("Nick", "You truly are a guru."));
        video4.AddComment(new Comment("Kim", "I need more content like this."));
        video4.AddComment(new Comment("Liam", "This helped a lot!"));
        videos.Add(video4);

        // Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }
        }
    }
}