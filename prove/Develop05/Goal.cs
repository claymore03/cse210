class Goal
{
    protected string _goalType = "";
    
    protected string _goalTitle = "";

    protected int _pointValue = 0;

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

    public void DisplayGoalInfo()
    {
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Title: {_goalTitle}\nPoint Value: {_pointValue}");
    }

    
    // public Goal(int pointValue)
    // {
    //     _pointValue = pointValue;
    // }

    // public abstract void DisplayGoal();
}