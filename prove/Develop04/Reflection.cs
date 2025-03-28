using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private string _userResponse;

    public ReflectionActivity(int timer) : base(timer) {}

    public void StartReflectionActivity()
    {
        Console.WriteLine("The Reflection Activity is about to begin!");
        Thread.Sleep(1500);

        string[] prompts = 
        {
            "Think about a time that made you happy.",
            "Reflect on a challenge you overcame.",
            "What is something you are grateful for?"
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
                _userResponse = Console.ReadLine();
                userResponses.Add(_userResponse);
            }

        Console.WriteLine();

        Console.WriteLine("\nTime's up! You wrote:");
        foreach (string response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }

    }

}