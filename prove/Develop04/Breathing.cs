class BreathingActivity : Activity
{
    public void StartBreathingActivity()
    {
        int cycles = 3; // Number of breathing cycles
        int inhaleTime = 4000;  // 4 seconds
        int holdTime = 4000;    // 4 seconds
        int exhaleTime = 8000;  // 8 seconds
        
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("\nInhale slowly...");
            Thread.Sleep(inhaleTime);

            Console.WriteLine("Hold your breath...");
            Thread.Sleep(holdTime);

            Console.WriteLine("Exhale gently...");
            Thread.Sleep(exhaleTime);
        }

    }

}

// class BreathingActivity : Activity
// {
//     public BreathingActivity(string name, int duration) : base(name, duration) { }

//     public override void Start()
//     {
//         Console.WriteLine("\nBreathing Activity: Focus on your breath to relax.");
//         AnimatePause();
//         int startTime = Environment.TickCount;
//         while ((Environment.TickCount - startTime) / 1000 < Duration)
//         {
//             Console.WriteLine("Breathe in...");
//             Thread.Sleep(2000);
//             Console.WriteLine("Breathe out...");
//             Thread.Sleep(2000);
//         }
//         EndingMessage();
//     }
// }