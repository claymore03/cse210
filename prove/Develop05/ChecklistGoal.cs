using System.Runtime.CompilerServices;
class ChecklistGoal : Goal
{
    public ChecklistGoal(string goalType, string goalTitle, int pointValue, int totalPoints) : base(goalType, goalTitle, pointValue, totalPoints)
    {

    }

    // public ChecklistGoal(List<string> goals) : base(goals)
    // {

    // }
    protected int _targetValue = 0;
    protected int _currentValue = 0;

    public int GetCurrentValue()
    {
        return _currentValue;
    }

    public void SetCurrentValue(int currentValue)
    {
        _currentValue = currentValue;
    }

    public int GetTargetValue()
    {
        return _targetValue;
    }

    public void SetTargetValue(int targetValue)
    {
        _targetValue = targetValue;
    }

    public void CompleteActivity()
    {
       bool running = true;

        while (running)
        {
            Console.WriteLine("Log an entry?");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "yes":
                    Console.WriteLine("Congratulations. You have completed a step.");
                    _currentValue ++;
                    break;
                case "no":
                    running = false;
                    Console.WriteLine("Come back when you're ready to make an entry.");
                    break;
                
            }

        }
    }

    public void DisplayChecklist()
    {
        Console.WriteLine($"You have completed this goal {_currentValue}/{_targetValue}");
    }

    public override void Points()
    {
        if (_currentValue == _targetValue)
        {
            _totalPoints = _totalPoints + _pointValue;
            Console.WriteLine($"Total Points: {_totalPoints}");
        }
        else if (_currentValue != _targetValue)
        {
            Console.WriteLine("You have not yet met this goals requirments.");
        }
        else
        {
            Console.WriteLine("Something went wrong.");
        }
    }
}

    
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
