using System;

class Program
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        EnumerationActivity enumerationActivity = new EnumerationActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Enumeration Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4.Quit");
            Console.Write("Make a selection: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.StartBreathingActivity();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "2":
                    enumerationActivity.StartEnumerationActivity();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;
                
                case "3":
                    reflectionActivity.StartReflectionActivity();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nGoodbye! Stay mindful.");
                    break;

                default:
                    Console.WriteLine("\nInvalid option! Please choose 1 or 2.");
                    Thread.Sleep(2000); // Wait before showing menu again
                    break;
            }
        }

        // breathingActivity.DisplayStartMessage();
        // breathingActivity.StartBreathingActivity();
        // breathingActivity.DisplayEndMessage();

        
        // reflectionActivity.DisplayStartMessage();
        // reflectionActivity.StartReflectionActivity();
        // reflectionActivity.DisplayEndMessage();

        
        // enumerationActivity.DisplayStartMessage();
        // enumerationActivity.StartEnumerationActivity();
        // enumerationActivity.DisplayEndMessage();
        
        // var activities = new Dictionary<string, Func<Activity>
        // {
        //     { "1", () => new BreathingActivity("Breathing Activity", 10) },
        //     { "2", () => new ReflectionActivity("Reflection Activity", 15) },
        //     { "3", () => new EnumerationActivity("Enumeration Activity", 20) }
        // };

        

        // string[] predefinedChoices = { "1", "2", "3", "4" }; // Simulated inputs

        // foreach (string choice in predefinedChoices)
        // {
        //     Console.WriteLine("\nMindfulness Activities Menu");
        //     Console.WriteLine("1. Breathing Activity");
        //     Console.WriteLine("2. Reflection Activity");
        //     Console.WriteLine("3. Enumeration Activity");
        //     Console.WriteLine("4. Exit");

        //     Console.WriteLine($"Simulated choice: {choice}");
        //     if (activities.ContainsKey(choice))
        //     {
        //         Activity activity = activities[choice]();
        //         activity.Start();
        //     }
        //     else if (choice == "4")
        //     {
        //         Console.WriteLine("Goodbye!");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid choice. Please try again.");
        //     }
        // }
    }
}