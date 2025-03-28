using System;
using System.Threading;

class Activity
{
    protected int _timer = 0;

    public Activity(int timer)
    {
        _timer = timer;
    }
    public int GetTimer()
    {
        return _timer;
    }

    public void SetTime(int timer)
    {
        _timer = timer;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the activity!");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Thank you for completing the activity.");
    }

    public void StartTimer(int time)
    {   
        for (int i = time; i > 0; i--)
        {
            Console.Write($"\r{i} seconds remaining... ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();

    }

    public void ShowSpinner(int seconds = 3)
{
    char[] spinner = { '|', '/', '-', '\\' }; // Spinner animation characters
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    int counter = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write($"\r{spinner[counter % spinner.Length]}"); // Overwrites the same line
        Thread.Sleep(200); // Adjust speed of spinner
        counter++;
    }

    Console.Write("\r "); // Clear spinner when done
}
}