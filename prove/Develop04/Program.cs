using System;

class Program
{
    static void Main()
    {
        var activities = new Dictionary<string, Func<Activity>
        {
            { "1", () => new BreathingActivity("Breathing Activity", 10) },
            { "2", () => new ReflectionActivity("Reflection Activity", 15) },
            { "3", () => new EnumerationActivity("Enumeration Activity", 20) }
        };

        string[] predefinedChoices = { "1", "2", "3", "4" }; // Simulated inputs

        foreach (string choice in predefinedChoices)
        {
            Console.WriteLine("\nMindfulness Activities Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Enumeration Activity");
            Console.WriteLine("4. Exit");

            Console.WriteLine($"Simulated choice: {choice}");
            if (activities.ContainsKey(choice))
            {
                Activity activity = activities[choice]();
                activity.Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}