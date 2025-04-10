class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int currentCount = 0)
    {
        Name = name;
        Description = description;
        Points = points;
        this.bonus = bonus;
        this.targetCount = targetCount;
        this.currentCount = currentCount;
    }

    public override void RecordEvent(ref int score)
    {
        if (currentCount < targetCount)
        {
            score += Points;
            currentCount++;
            if (currentCount == targetCount)
            {
                score += bonus;
            }
        }
    }

    public override string GetStatus() => currentCount >= targetCount ? "[X]" : "[ ]";
    public override string GetStringRepresentation() => $"ChecklistGoal|{Name}|{Description}|{Points}|{bonus}|{targetCount}|{currentCount}";
}
