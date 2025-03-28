abstract class Goal
{
    protected string _name;
    
    public Goal(string name)
    {
        _name = name;
    }

    public abstract void DisplayGoal();
}