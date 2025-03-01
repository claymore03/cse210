class EnumerationActivity : Activity
{
    public EnumerationActivity(string name, int duration) : base(name, duration) { }

    public override void Start()
    {
        Console.WriteLine("\nEnumeration Activity: List as many things as you can within the time limit.");
        AnimatePause();
        Console.WriteLine($"You have {Duration} seconds to list items!");
        Thread.Sleep(Duration * 1000);
        EndingMessage();
    }
}