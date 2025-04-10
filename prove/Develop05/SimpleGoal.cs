class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points, bool complete = false)
    {
        Name = name;
        Description = description;
        Points = points;
        isComplete = complete;
    }

    public override void RecordEvent(ref int score)
    {
        if (!isComplete)
        {
            score += Points;
            isComplete = true;
        }
    }

    public override string GetStatus() => isComplete ? "[X]" : "[ ]";
    public override string GetStringRepresentation() => $"SimpleGoal|{Name}|{Description}|{Points}|{isComplete}";
}
