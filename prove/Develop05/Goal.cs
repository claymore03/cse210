// abstract class Goal
// {
//     public string Name { get; set; }
//     public int Points { get; protected set; }
//     public bool IsCompleted { get; protected set; }
    
//     public static List<Goal> Goals = new List<Goal>();
//     private static string filePath = "goals.txt";

//     public Goal(string name, int points)
//     {
//         Name = name;
//         Points = points;
//         IsCompleted = false;
//     }
    
//     public abstract void Complete();
//     public abstract string SaveFormat();
    
//     public static void SaveGoals()
//     {
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             foreach (var goal in Goals)
//             {
//                 writer.WriteLine(goal.SaveFormat());
//             }
//         }
//         Console.WriteLine("Goals saved successfully.");
//     }

//     public static void LoadGoals()
//     {
//         Goals.Clear();
//         if (File.Exists(filePath))
//         {
//             foreach (var line in File.ReadAllLines(filePath))
//             {
//                 string[] parts = line.Split('|');
//                 if (parts[0] == "OneTimeGoal")
//                     Goals.Add(new OneTimeGoal(parts[1], int.Parse(parts[2])));
//                 else if (parts[0] == "EternalGoal")
//                     Goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
//                 else if (parts[0] == "ChecklistGoal")
//                     Goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[4])));
//             }
//         }
//     }
// }


class Goal
{
    protected string _goalType = "";
    
    protected string _goalTitle = "";

    protected int _pointValue = 0;

    protected int _totalPoints = 0;

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
    }

    public void DisplayGoalList()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine("Goal successfully added to list!!");
            DisplayGoalInfo();
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

    // public abstract void DisplayGoal();
}