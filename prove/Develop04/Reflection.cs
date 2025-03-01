class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, int duration) : base(name, duration) { }

    public override void Start()
    {
        Console.WriteLine("\nReflection Activity: Think deeply about meaningful experiences.");
        AnimatePause();
        string[] prompts =
        {
            "Think of a time when you felt truly at peace.",
            "Recall a moment when you overcame a challenge.",
            "What is something you are grateful for today?"
        };
        int startTime = Environment.TickCount;
        while ((Environment.TickCount - startTime) / 1000 < Duration)
        {
            foreach (var prompt in prompts)
            {
                if ((Environment.TickCount - startTime) / 1000 >= Duration)
                    break;
                Console.WriteLine(prompt);
                Thread.Sleep(5000);
            }
        }
        EndingMessage();
    }
}