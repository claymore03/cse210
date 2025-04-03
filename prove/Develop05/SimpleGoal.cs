// class OneTimeGoal : Goal
// {
//     public OneTimeGoal(string name, int points) : base(name, points) { }
    
//     public override void Complete()
//     {
//         if (!IsCompleted)
//         {
//             IsCompleted = true;
//             Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
//         }
//         else
//         {
//             Console.WriteLine("This goal has already been completed.");
//         }
//     }

//     public override string SaveFormat()
//     {
//         return $"OneTimeGoal|{Name}|{Points}|{IsCompleted}";
//     }
// }

class SimpleGoal : Goal
{
    
    private string _answer = "";

    public SimpleGoal(string goalType, string goalTitle, int pointValue, int totalPoints) : base(goalType, goalTitle, pointValue, totalPoints)
    {

    }

    // public SimpleGoal(List<string> goals) : base(goals)
    // {

    // }

    public override void Points()
    {
        Console.WriteLine("Did you accomplish this goal? (y/n): ");
        _answer = Console.ReadLine().ToLower();

        if (_answer == "y")
        {
            Console.WriteLine($"Congratulations! You scored {_pointValue}");
            _totalPoints = _totalPoints + _pointValue;
            Console.WriteLine($"Total Points: {_totalPoints}");
        }
        else if (_answer == "n")
        {
            Console.WriteLine("Keep trying!");
        }
        else
        {
            Console.WriteLine("ERROR: Please enter 'y' or 'n'.");
        }
        
    }


    public void CheckSimpleComplete()
    {
        
    }



}
