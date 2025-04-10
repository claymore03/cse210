class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void RecordEvent(ref int score)
    {
        score += Points;
    }

    public override string GetStatus() => "[∞]";
    public override string GetStringRepresentation() => $"EternalGoal|{Name}|{Description}|{Points}";
}