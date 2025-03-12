

class EnumerationActivity : Activity
{
    // public EnumerationActivity(string name, int duration) : base(name, duration) { }

    public void StartEnumerationActivity()
    {
        int seconds = 30000;
        Thread.Sleep(8000);
        Console.WriteLine("\nEnumeration Activity: List as many things as you can within the time limit.");
        // AnimatePause();
        Console.WriteLine($"You have {seconds/1000} seconds to list items!");
        Thread.Sleep(seconds);
    }
}