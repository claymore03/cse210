class EternalGoal : Goal
{
    public EternalGoal(int pointValue, int totalPoints) : base(pointValue, totalPoints)
    {
        
    }
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

            switch (choice)
            {
                case "yes":
                    Console.WriteLine("Tally added.");
                    _tally ++;
                    break;
                case "no":
                    running = false;
                    Console.WriteLine("Come back when you're ready to make an entry.");
                    break;
                
            }

        }
    }

    public void DisplayTallys()
    {
        Console.WriteLine($"You have completed this activity {_tally} times.");
    }
}