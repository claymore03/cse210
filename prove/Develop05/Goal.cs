abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
    public static void SaveGoals(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public static (List<Goal>, int) LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            if (lines.Length > 0)
            {
                score = int.Parse(lines[0]);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];
                    switch (type)
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                            break;
                    }
                }
            }
        }
        return (goals, score);
    }
}