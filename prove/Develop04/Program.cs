using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Enumeration Activity");
            Console.WriteLine("4.Quit");
            Console.Write("Make a selection: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter time for activity in seconds: ");
                    BreathingActivity breathingActivity = new BreathingActivity(Convert.ToInt32(Console.ReadLine()));
                    breathingActivity.DisplayWelcomeMessage();
                    breathingActivity.ShowSpinner();
                    breathingActivity.StartBreathingActivity();
                    breathingActivity.DisplayEndMessage();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Enter time for activity in seconds: ");
                    ReflectionActivity reflectionActivity = new ReflectionActivity(Convert.ToInt32(Console.ReadLine()));
                    reflectionActivity.DisplayWelcomeMessage();
                    reflectionActivity.ShowSpinner();
                    reflectionActivity.StartReflectionActivity();
                    reflectionActivity.DisplayEndMessage();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;
                
                case "3":
                    Console.Write("Enter time for activity in seconds: ");
                    EnumerationActivity enumerationActivity = new EnumerationActivity(Convert.ToInt32(Console.ReadLine()));
                    enumerationActivity.DisplayWelcomeMessage();
                    enumerationActivity.ShowSpinner();
                    enumerationActivity.StartEnumerationActivity();
                    enumerationActivity.DisplayEndMessage();
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
    }
}