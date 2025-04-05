public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in miles via 50 meter laps
        return (laps * 50.0 / 1000) * 0.62; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        // Speed in miles per hour
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // Pace in minutes per mile
        return LengthInMinutes / GetDistance();
    }
}