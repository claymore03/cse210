using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(int timer) : base(timer) {}

    public void StartBreathingActivity()
    {
        Console.WriteLine("The Breathing Activity is about to begin.");
        Thread.Sleep(1500);

        for (int i = 0; i < base._timer/10; i++)
        {
            Console.WriteLine("\nInhale slowly...");
            base.StartTimer(5);

            Console.WriteLine("Exhale gently...");
            base.StartTimer(5);
        }

    }

}