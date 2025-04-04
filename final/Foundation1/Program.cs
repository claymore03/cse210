using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1.SetVideoName("How to Play the Guitar");
        video1.SetVideoDate("09/12/2014");
        video1.SetVideoDuration(330);

        video1.DisplayVideoInfo();
    }
}