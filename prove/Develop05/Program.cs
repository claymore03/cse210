using System;
using System.Runtime.CompilerServices;

// class Program
// {
//     static int totalScore = 0;

//     static void Main()
//     {
//         Goal.LoadGoals();
//         while (true)
//         {
//             Console.WriteLine("\nGoal Tracking Program");
//             Console.WriteLine("1. Create Goal");
//             Console.WriteLine("2. View Goals");
//             Console.WriteLine("3. Complete Goal");
//             Console.WriteLine("4. Save and Exit");
//             Console.Write("Choose an option: ");
            
//             string choice = Console.ReadLine();
//             switch (choice)
//             {
//                 case "1": CreateGoal(); break;
//                 case "2": ViewGoals(); break;
//                 case "3": CompleteGoal(); break;
//                 case "4": Goal.SaveGoals(); return;
//                 default: Console.WriteLine("Invalid option, try again."); break;
//             }
//         }
//     }

//     static void CreateGoal()
//     {
//         Console.Write("Enter goal name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter point value: ");
//         int points = int.Parse(Console.ReadLine());
//         Console.WriteLine("Select goal type: 1) One-Time 2) Eternal 3) Checklist");
//         string type = Console.ReadLine();

//         switch (type)
//         {
//             case "1": Goal.Goals.Add(new OneTimeGoal(name, points)); break;
//             case "2": Goal.Goals.Add(new EternalGoal(name, points)); break;
//             case "3":
//                 Console.Write("Enter target count: ");
//                 int target = int.Parse(Console.ReadLine());
//                 Goal.Goals.Add(new ChecklistGoal(name, points, target));
//                 break;
//             default: Console.WriteLine("Invalid type, goal not created."); break;
//         }
//     }

//     static void ViewGoals()
//     {
//         if (Goal.Goals.Count == 0)
//         {
//             Console.WriteLine("No goals available.");
//             return;
//         }
//         Console.WriteLine("\nGoals:");
//         for (int i = 0; i < Goal.Goals.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {Goal.Goals[i].Name} - {Goal.Goals[i].Points} pts");
//         }
//     }

//     static void CompleteGoal()
//     {
//         ViewGoals();
//         Console.Write("Enter goal number to complete: ");
//         int index = int.Parse(Console.ReadLine()) - 1;
//         if (index >= 0 && index < Goal.Goals.Count)
//         {
//             Goal.Goals[index].Complete();
//             totalScore += Goal.Goals[index].Points;
//             Console.WriteLine($"Total Score: {totalScore}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid selection.");
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        // ChecklistGoal goal = new ChecklistGoal(0, 0);
        
        // goal.SetGoalType("[Checklist]");
        // goal.SetGoalTitle("Drink Water");
        // goal.SetPointValue(35);
        // goal.DisplayGoalInfo();
        // goal.SetTargetValue(3);
        // goal.DisplayChecklist();
        // goal.CompleteActivity();
        // goal.DisplayGoalInfo();
        // goal.DisplayChecklist();
        // goal.Points();
    
        // string goalName;
        // Console.Write("Give this goal a title: ");
        // goalName = Console.ReadLine();
        // Console.Write("How many times would you like to complete this goal: ");
        
        // string target;
        // Console.Write("");
        // target = Console.ReadLine();

        // SimpleGoal simple = new SimpleGoal(0, 0);
        
        
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

        bool running = true;

        Goal goal = new Goal("", "", 0, 0);
        SimpleGoal simple = new SimpleGoal("", "", 0, 0);
        ChecklistGoal checkList = new ChecklistGoal("", "", 0, 0);
        EternalGoal eternal = new EternalGoal("", "", 0, 0);

        while (running)
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Update goal");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4.Load goals");
            Console.WriteLine("5.Quit");
            Console.Write("Make a selection: ");

            string choice = Console.ReadLine();

            // SimpleGoal simple = new SimpleGoal(0, 0);

            switch (choice)
            {
                case "1":
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");
                    string choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "1":
                            
                            simple.SetGoalType("[Simple]");
                            Console.Write("What would you like to call this goal?: ");
                            simple.SetGoalTitle(Console.ReadLine());
                            Console.Write("How many points should this goal be worth?: ");
                            simple.SetPointValue(Convert.ToInt32(Console.ReadLine()));
                            // simple.DisplayGoalInfo();
                            // simple.Points();
                            simple._goals.Add(simple);
                            simple.DisplayGoalList();
                            // simple.DisplayGoalInfo();
                            // simple.DisplayGoalList();
                            // simple.AddToList();
                            Console.WriteLine("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case "2":
                            checkList.SetGoalType("[Checklist]");
                            Console.Write("What would you like to call this goal?: ");
                            checkList.SetGoalTitle(Console.ReadLine());
                            Console.Write("How many times would you like to complete this activity?");
                            checkList.SetTargetValue(Convert.ToInt32(Console.ReadLine()));
                            Console.Write("How many points should this goal be worth?: ");
                            checkList.SetPointValue(Convert.ToInt32(Console.ReadLine()));
                            checkList.DisplayGoalInfo();
                            checkList.DisplayChecklist();
                            checkList.CompleteActivity();
                            checkList.DisplayGoalInfo();
                            checkList.DisplayChecklist();
                            checkList.Points();
                            // checkList.DisplayGoalList();
                            Console.WriteLine("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case "3":
                            eternal.SetGoalType("[Eternal]");
                            Console.Write("What would you like to call this goal?: ");
                            eternal.SetGoalTitle(Console.ReadLine());
                            Console.Write("How many points should this goal be worth?: ");
                            eternal.SetPointValue(Convert.ToInt32(Console.ReadLine()));
                            eternal.DisplayGoalInfo();
                            eternal.CompletedEternalTask();
                            eternal.DisplayTallys();
                            eternal.Points();
                            eternal.DisplayGoalInfo();
                            // eternal.DisplayGoalList();
                            Console.WriteLine("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                            
                    }
                    
                    break;

                case "2":
                    simple.DisplayGoalList();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;
                
                case "3":
                    // Console.Write("Enter time for activity in seconds: ");
                    // EnumerationActivity enumerationActivity = new EnumerationActivity(Convert.ToInt32(Console.ReadLine()));
                    // enumerationActivity.DisplayWelcomeMessage();
                    // enumerationActivity.ShowSpinner();
                    // enumerationActivity.StartEnumerationActivity();
                    // enumerationActivity.DisplayEndMessage();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nGoodbye! Stay mindful.");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nGoodbye!.");
                    break;

                default:
                    Console.WriteLine("\nInvalid option! Please choose 1 or 2.");
                    Thread.Sleep(2000); // Wait before showing menu again
                    break;
            }
        }
        

        // simple.EntryLoop();
        // simple.DisplayGoal();
    }
}