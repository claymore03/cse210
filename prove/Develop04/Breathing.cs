class BreathingActivity : Activity
{
    public BreathingActivity(string name, int duration) : base(name, duration) { }

    public override void Start()
    {
        Console.WriteLine("\nBreathing Activity: Focus on your breath to relax.");
        AnimatePause();
        int startTime = Environment.TickCount;
        while ((Environment.TickCount - startTime) / 1000 < Duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
        }
        EndingMessage();
    }
}