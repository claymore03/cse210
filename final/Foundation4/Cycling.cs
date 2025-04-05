public class Cycling : Activity
{
    private double speed; // in miles per hour

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        // Distance in miles
        return (speed * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed; // Speed is already given in mph
    }

    public override double GetPace()
    {
        // Pace in minutes per mile
        return 60 / speed;
    }
}