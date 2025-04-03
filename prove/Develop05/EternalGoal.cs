// class EternalGoal : Goal
// {
//     public EternalGoal(string name, int points) : base(name, points) { }
    
//     public override void Complete()
//     {
//         Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
//     }

//     public override string SaveFormat()
//     {
//         return $"EternalGoal|{Name}|{Points}";
//     }
// }

class EternalGoal : Goal
{
    public EternalGoal(string goalType, string goalTitle, int pointValue, int totalPoints) : base(goalType, goalTitle, pointValue, totalPoints)
    {

    }

    // public EternalGoal(List<string> goals) : base(goals)
    // {

    // }
    protected int _tally;

    public int GetTally()
    {
        return _tally;
    }

    public void SetTally(int tally)
    {
        _tally = tally;
    }

    public void CompletedEternalTask()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Log an entry? (yes/no)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.WriteLine("Tally added.");
                _tally ++;
            }
            else if (choice == "no")
            {
                running = false;
                Console.WriteLine("Come back when you're ready to make an entry.");
            }
            // switch (choice)
            // {
            //     case "yes":
            //         Console.WriteLine("Tally added.");
            //         _tally ++;
            //     case "no":
            //         running = false;
            //         Console.WriteLine("Come back when you're ready to make an entry.");
            //         break;
                
            // }

        }
    }

    public override void Points()
    {
        Console.WriteLine($"You have completed this activity {_tally} times.");
        _totalPoints = _totalPoints + _pointValue * _tally;
    }

    public void DisplayTallys()
    {
        
    }
}