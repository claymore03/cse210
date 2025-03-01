public Activity(string name, int duration)
{
    protected string Name;
    protected int Duration;
    
    {
        Name = name;
        Duration = duration;
    }

    protected void AnimatePause(int duration = 3)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"Starting in {i} seconds...\r");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Ready to begin!");
    }

    protected void EndingMessage()
    {
        Console.WriteLine("\nGreat job!");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Thread.Sleep(2000);
    }

    public abstract void Start();
};
