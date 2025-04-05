public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        // Speed in miles per hour
        return (distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // Pace in minutes per mile
        return LengthInMinutes / distance;
    }
}