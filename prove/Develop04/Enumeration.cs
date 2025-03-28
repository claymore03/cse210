using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class EnumerationActivity : Activity
{
    private string _userInput;

    public EnumerationActivity(int timer) : base(timer) {}

    public void StartEnumerationActivity()
    {
        Console.WriteLine("The Enumeration Activity is about to begin!");
        Thread.Sleep(1500);

        string[] prompts = 
        {
            "List people you are grateful for.",
            "Count your many blessings.",
            "List what you see in your surroundings."
        };

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"{selectedPrompt}");
        Console.WriteLine();
        
        DateTime endTime = DateTime.Now.AddSeconds(base._timer);
        List<string> userResponses = new List<string>();
        while(DateTime.Now < endTime)
            {
                Console.Write("> ");
                _userInput = Console.ReadLine();
                userResponses.Add(_userInput);
            }

        Console.WriteLine();

        Console.WriteLine("\nTime's up! You wrote:");
        foreach (string response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }

        Console.WriteLine($"You listed a total of {userResponses.Count()} items.");

    }
}