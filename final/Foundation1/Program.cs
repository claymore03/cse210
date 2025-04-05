using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    Video video1 = new Video("C# Basics", "Alice", 300);
        video1.AddComment("Bob", "This was helpful!");
        video1.AddComment("Jane", "Nice explanation.");

        Video video2 = new Video("OOP in C#", "Mike", 480);
        video2.AddComment("Sara", "Very detailed.");
        video2.AddComment("Tom", "Loved the examples!");

        Video video3 = new Video("LINQ Tutorial", "Lina", 250);
        video3.AddComment("Jim", "Perfect timing for my project.");
        video3.AddComment("Eva", "Thanks!");

        video1.DisplayInfo();
        video2.DisplayInfo();
        video3.DisplayInfo();
    }
}