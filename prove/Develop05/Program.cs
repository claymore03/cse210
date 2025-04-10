using System;
using System.Runtime.CompilerServices;
class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    const string filePath = "eternal_quest.txt";
    
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine($"\nScore: {score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int pts = int.Parse(Console.ReadLine());

                    if (type == "1")
                        goals.Add(new SimpleGoal(name, desc, pts));
                    else if (type == "2")
                        goals.Add(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goals.Add(new ChecklistGoal(name, desc, pts, bonus, target));
                    }
                    break;
                case "2":
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} ({goals[i].Description})");
                    }
                    break;
                case "3":
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].Name}");
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    goals[index].RecordEvent(ref score);
                    break;
                case "4":
                    Goal.SaveGoals(goals, score);
                    Console.WriteLine("Goals saved.");
                    break;
                case "5":
                    (goals, score) = Goal.LoadGoals();
                    Console.WriteLine("Goals loaded.");
                    break;
                case "6":
                    return;
            }
        }
    }
}