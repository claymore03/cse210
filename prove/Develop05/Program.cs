using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string goalName;
        Console.Write("Give this goal a title: ");
        goalName = Console.ReadLine();
        Console.Write("How many times would you like to complete this goal: ");
        
        string target;
        Console.Write("");
        target = Console.ReadLine();

        ChecklistGoal checklist = new ChecklistGoal(goalName, Convert.ToInt32(target));
        
        checklist.AskIfCompleted();
        checklist.DisplayGoal();
    }
}