class Goal
{
    protected string _goalType = "";
    
    protected string _goalTitle = "";

    protected int _pointValue = 0;

    protected int _totalPoints = 0;

    private List<string> _goals = new List<string>();

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
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Title: {_goalTitle}\nPoint Value: {_pointValue}");
    }

    public void DisplayGoalList()
    {
        foreach (string goal in _goals)
        {
            _goals.Add(_goalTitle);
            Console.WriteLine(_goals);
        }
    }

    
    // public Goal(string _goalType, string _goalTitle, int _pointValue)
    // {
    //     _goalType = _goalType;
    //     _goalTitle = _goalTitle;
    //     _pointValue = pointValue;
    // }

    // public abstract void DisplayGoal();
}