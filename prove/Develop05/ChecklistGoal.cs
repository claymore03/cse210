class ChecklistGoal : Goal
{
    
    
    // public ChecklistGoal(string goalTitle) : base(goalTitle)
    // {

    // }
    // private int targetCount;
    // private int currentCount;
    // private int completionBonus = 100;

    // public ChecklistGoal(string _name, int target) : base(_name)
    // {
    //     targetCount = target;
    //     currentCount = 0;
    // }

    // public void CompleteStep()
    // {
    //     if (currentCount < targetCount)
    //     {
    //         currentCount++;
    //         Console.WriteLine($"Step completed! You have completed {currentCount}/{targetCount} steps.");
            
    //         if (currentCount == targetCount)
    //         {
    //             Console.WriteLine($"Congratulations! You completed the goal! You've earned {completionBonus} points.");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Checklist goal already completed!");
    //     }
    // }
    // public void EntryLoop()
    // {
    //     while (true)
    //     {
    //         Console.WriteLine("Would you like to make an entry? (y/n)");
    //         string response = Console.ReadLine().ToLower();

    //         if (response == "y")
    //         {
    //             AskIfCompleted(); // Prompt the user to record the entry
    //         }
    //         else if (response == "n")
    //         {
    //             Console.WriteLine("Ending the entry process.");
    //             break; // Exit the loop if user answers no
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
    //         }
    //     }
    // }  
    

    // public void AskIfCompleted()
    // {
    //     Console.WriteLine($"Have you completed this step of the goal: {_name}? (y/n)");

    //     string userInput = Console.ReadLine().ToLower();
        
    //     if (userInput == "y")
    //     {
    //         CompleteStep();
    //     }
    //     else
    //     {
    //         Console.WriteLine("No progress made for this step.");
    //     }
    // }

    // public override void DisplayGoal()
    // {
    //     Console.WriteLine($"[Checklist Goal] {_name} ({currentCount}/{targetCount} completed)");
    // }

    // public int GetTotalPoints()
    // {
    //     // Return points: 100 for completion + 10 for each individual step completed
    //     return currentCount == targetCount ? completionBonus : currentCount * 10;
    // }
}
