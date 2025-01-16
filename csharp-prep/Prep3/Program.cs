using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess My Number!");
        
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        
        string userInput;

        Convert.ToString(number);
        Console.WriteLine("The magic number is " + number);
        
        Console.Write("Enter your guess: ");
        userInput = Console.ReadLine();
        Console.WriteLine("You're guess was " + userInput);

        int guess = int.Parse(userInput);

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Too low. Guess higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high! Guess lower.");
            }
            else
            {
                Console.WriteLine("Something went wrong");

                break;
            }

            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();
            Console.WriteLine("You're guess was " + userInput);

            guess = int.Parse(userInput);
        }

        Console.WriteLine("Congratulations! You guessed it!");

    }
}