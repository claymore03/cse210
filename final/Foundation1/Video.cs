using System;
using System.Collections.Generic;
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>(); // Initialize the list
    }

    public void AddComment(string author, string text)
    {
        Comments.Add(new Comment(author, text));
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.Author}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
// class Video
// {
//     private string _videoName;

//     private string _videoDate;

//     private int _videoDuration;

//     public List<string> _comments = new List<string>();

//     public string GetVideoName()
//     {
//         return _videoName;
//     }

//     public void SetVideoName(string videoName)
//     {
//         _videoName = videoName;
//     }  
//     public string GetVideoDate()
//     {
//         return _videoDate;
//     }

//     public void SetVideoDate(string videoDate)
//     {
//         _videoDate = videoDate;
//     } 

//     public int GetVideoDuration()
//     {
//         return _videoDuration;
//     }

//     public void SetVideoDuration(int videoDuration)
//     {
//         _videoDuration = videoDuration;
//     } 
    

//     public void DisplayVideoInfo()
//     {
//         Console.WriteLine($"Title: {_videoName}");
//         Console.WriteLine($"Published: {_videoDate}");
//         Console.WriteLine($"Duration: {_videoDuration} seconds");
//     }

//     public void AddComments()
//     {
//         foreach (string comment in _comments)
//         {
//             Console.WriteLine(_comments);
//         }
//     }
// }