using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        ChecklistGoal goal = new ChecklistGoal();
        
        goal.GetCurrentValue();
        goal.CompleteActivity();
        goal.SetTargetValue(3);
        goal.DisplayChecklist();
        // string goalName;
        // Console.Write("Give this goal a title: ");
        // goalName = Console.ReadLine();
        // Console.Write("How many times would you like to complete this goal: ");
        
        // string target;
        // Console.Write("");
        // target = Console.ReadLine();

        // simpleGoal simple = new simpleGoal();
        
        
        // simple.SetGoalType("[simple]");
        // Console.Write("What would you like to call this goal?: ");
        // simple.SetGoalTitle(Console.ReadLine());
        // Console.Write("How many points should this goal be worth?: ");
        // simple.SetPointValue(Convert.ToInt32(Console.ReadLine()));
        // simple.DisplayGoalInfo();

        // simple.SetGoalType("[Simple]");
        // Console.Write("What would you like to call this goal?: ");
        // simple.SetGoalTitle(Console.ReadLine());
        // Console.Write("How many points should this goal be worth?: ");
        // simple.SetPointValue(Convert.ToInt32(Console.ReadLine()));
        // simple.DisplayGoalInfo();
        // simple.CheckIfGoalIsComplete();

        // bool running = true;

        // while (running)
        // {
        //     Console.WriteLine("1. Create new goal");
        //     Console.WriteLine("2. Update goal");
        //     Console.WriteLine("3. Save goals");
        //     Console.WriteLine("4.Load goals");
        //     Console.WriteLine("5.Quit");
        //     Console.Write("Make a selection: ");

        //     string choice = Console.ReadLine();

        //     switch (choice)
        //     {
        //         case "1":
        //             Console.WriteLine("1. Simple Goal");
        //             Console.WriteLine("2. Checklist Goal");
        //             Console.WriteLine("3. Eternal Goal");
        //             string choice1 = Console.ReadLine();
        //             switch (choice1)
        //             {
        //                 case "1":
        //                     SimpleGoal simple = new SimpleGoal();
        //                     simple.SetGoalType("[Simple]");
        //                     Console.Write("What would you like to call this goal?: ");
        //                     simple.SetGoalTitle(Console.ReadLine());
        //                     Console.Write("How many points should this goal be worth?: ");
        //                     simple.SetPointValue(Convert.ToInt32(Console.ReadLine()));
        //                     simple.DisplayGoalInfo();
        //                     simple.DisplayGoalList();
        //                     Console.WriteLine("\nPress any key to return to the menu...");
        //                     Console.ReadKey();
        //                     break;
        //                 case "2":
        //                     ChecklistGoal checkList = new ChecklistGoal();
        //                     checkList.SetGoalType("[Checklist]");
        //                     Console.Write("What would you like to call this goal?: ");
        //                     checkList.SetGoalTitle(Console.ReadLine());
        //                     Console.Write("How many points should this goal be worth?: ");
        //                     checkList.SetPointValue(Convert.ToInt32(Console.ReadLine()));
        //                     checkList.DisplayGoalInfo();
        //                     checkList.DisplayGoalList();
        //                     Console.WriteLine("\nPress any key to return to the menu...");
        //                     Console.ReadKey();
        //                     break;
        //                 case "3":
        //                     EternalGoal eternal = new EternalGoal();
        //                     eternal.SetGoalType("[Eternal]");
        //                     Console.Write("What would you like to call this goal?: ");
        //                     eternal.SetGoalTitle(Console.ReadLine());
        //                     Console.Write("How many points should this goal be worth?: ");
        //                     eternal.SetPointValue(Convert.ToInt32(Console.ReadLine()));
        //                     eternal.DisplayGoalInfo();
        //                     eternal.DisplayGoalList();
        //                     Console.WriteLine("\nPress any key to return to the menu...");
        //                     Console.ReadKey();
        //                     break;
                            
        //             }
                    
        //             break;

        //         case "2":
        //             // Console.Write("Enter time for activity in seconds: ");
        //             // ReflectionActivity reflectionActivity = new ReflectionActivity(Convert.ToInt32(Console.ReadLine()));
        //             // reflectionActivity.DisplayWelcomeMessage();
        //             // reflectionActivity.ShowSpinner();
        //             // reflectionActivity.StartReflectionActivity();
        //             // reflectionActivity.DisplayEndMessage();
        //             Console.WriteLine("\nPress any key to return to the menu...");
        //             Console.ReadKey();
        //             break;
                
        //         case "3":
        //             // Console.Write("Enter time for activity in seconds: ");
        //             // EnumerationActivity enumerationActivity = new EnumerationActivity(Convert.ToInt32(Console.ReadLine()));
        //             // enumerationActivity.DisplayWelcomeMessage();
        //             // enumerationActivity.ShowSpinner();
        //             // enumerationActivity.StartEnumerationActivity();
        //             // enumerationActivity.DisplayEndMessage();
        //             Console.WriteLine("\nPress any key to return to the menu...");
        //             Console.ReadKey();
        //             break;

        //         case "4":
        //             running = false;
        //             Console.WriteLine("\nGoodbye! Stay mindful.");
        //             break;

        //         case "5":
        //             running = false;
        //             Console.WriteLine("\nGoodbye!.");
        //             break;

        //         default:
        //             Console.WriteLine("\nInvalid option! Please choose 1 or 2.");
        //             Thread.Sleep(2000); // Wait before showing menu again
        //             break;
        //     }
        // }
        

        // simple.EntryLoop();
        // simple.DisplayGoal();
    }
}