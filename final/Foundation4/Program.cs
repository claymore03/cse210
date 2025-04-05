using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        // Add Running activity
        activities.Add(new Running(new DateTime(2024, 11, 15), 30, 3.0));

        // Add Cycling activity
        activities.Add(new Cycling(new DateTime(2024, 12, 22), 30, 18.0));

        // Add Swimming activity
        activities.Add(new Swimming(new DateTime(2025, 01, 31), 30, 20));

        // Display the summary of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}