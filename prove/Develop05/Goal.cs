class Goal
{
    protected string _goalType = "";
    
    protected string _goalTitle = "";

    protected int _pointValue = 0;

    protected int _totalPoins = 0;

    public List<Goal> _goals = new List<Goal>();

    public string GetGoalTitle()
    {
        return _goalTitle;
    }

    public void SetGoalTitle(string goalTitle)
    {
        _goalTitle = goalTitle;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public void SetPointValue(int pointValue)
    {
        _pointValue = pointValue;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    virtual public void DisplayGoalInfo()
    {
        Console.WriteLine(_goalType);
        Console.WriteLine(_goalTitle);
        Console.WriteLine(_pointValue);
        Console.WriteLine(_totalPoins);
    }

    public void DisplayGoalList()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine("Goal successfully added to list!!");
            goal.DisplayGoalInfo();
        }
    }

    // foreach (Entry entry in _entriesList)
    //     {
    //         entry.DisplayEntry(); 
    //     }


    public virtual void Points()
    {

    }

    public virtual void AddToList()
    {

    }

    // public Goal(List<string> goals)
    // {
    //     _goals = goals;
    // }


    
    public Goal(string goalType, string goalTitle, int pointValue, int totalPoints)
    {
        _goalType = goalType;
        _goalTitle = goalTitle;
        _pointValue = pointValue;
        _totalPoints = totalPoints;
    }

}