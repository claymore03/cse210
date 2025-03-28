class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int completionBonus = 100;

    public ChecklistGoal(string _name, int target) : base(_name)
    {
        targetCount = target;
        currentCount = 0;
    }

    public void CompleteStep()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            Console.WriteLine($"Step completed! You have completed {currentCount}/{targetCount} steps.");
            
            if (currentCount == targetCount)
            {
                Console.WriteLine($"Congratulations! You completed the goal! You've earned {completionBonus} points.");
            }
        }
        else
        {
            Console.WriteLine("Checklist goal already completed!");
        }
    }

    public void AskIfCompleted()
    {
        Console.WriteLine($"Have you completed this step of the goal: {_name}? (y/n)");

        string userInput = Console.ReadLine().ToLower();
        
        if (userInput == "y")
        {
            CompleteStep();
        }
        else
        {
            Console.WriteLine("No progress made for this step.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[Checklist Goal] {_name} ({currentCount}/{targetCount} completed)");
    }

    public int GetTotalPoints()
    {
        // Return points: 100 for completion + 10 for each individual step completed
        return currentCount == targetCount ? completionBonus : currentCount * 10;
    }
}
