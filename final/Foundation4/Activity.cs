public abstract class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    public Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    // Virtual methods to be overridden in derived classes
    public virtual double GetDistance()
    {
        return 0; // Default 
    }

    public virtual double GetSpeed()
    {
        return 0; // Default 
    }

    public virtual double GetPace()
    {
        return 0; // Default 
    }

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({LengthInMinutes} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}