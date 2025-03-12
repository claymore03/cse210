class ReflectionActivity : Activity
{
//     public ReflectionActivity(string name, int duration) : base(name, duration) { }

    public void StartReflectionActivity()
    {
        int cycles = 1; // Number of breathing cycles
        int timer = 10000;  // 4 seconds
        
        for (int i = 0; i < cycles; i++)
        {
            Thread.Sleep(timer-8000);
            
            Console.WriteLine("\nThink of a time you felt truly at peace.");
            Thread.Sleep(timer);

            Console.WriteLine("Recall a moment when you overcame a challenge.");
            Thread.Sleep(timer);

            Console.WriteLine("What is something you are grateful for today?");
            Thread.Sleep(timer);

            Thread.Sleep(timer-8000);
        }
        
        // Console.WriteLine("\nReflection Activity: Think deeply about meaningful experiences.");
        // // AnimatePause();
        // int duration = 8000;
        // string[] prompts =
        // {
        //     "Think of a time when you felt truly at peace.",
        //     "Recall a moment when you overcame a challenge.",
        //     "What is something you are grateful for today?"
        // };
        // int startTime = Environment.TickCount;
        // while ((Environment.TickCount - startTime) / 1000 < duration)
        // {
        //     foreach (var prompt in prompts)
        //     {
        //         if ((Environment.TickCount - startTime) / 1000 >= duration)
        //             break;
        //         Console.WriteLine(prompt);
        //         Thread.Sleep(5000);
        //     }
        // }
        // EndingMessage();
    }
}