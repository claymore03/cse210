//Name: Clayton Redding
//Date: 01/11/2025
//Course: CSE 210
//Professor: Brother Parrish
using System;

class Program
{
    static void Main(string[] args)
    {
        //Set variable for user input.
        string userInput;
        
        //Get input for userInput from the user.
        Console.Write("Enter your test score: ");
        userInput = Console.ReadLine();
        
        //Convert user input to an int variable
        int score = int.Parse(userInput);
        //Create variable for letter grade.
        string letter;

        //Create if statement to determine letter grade based off user input
        if (score < 60)
        {
            letter = "F";
            Console.Write(letter);
        }
        else if (score < 70 && score >= 60 )
        {
            letter = "D";
            Console.Write(letter);
        }
        else if (score < 80 && score >= 70 )
        {
            letter = "C";
            Console.Write(letter);
        }
        else if (score < 90 && score >= 80 )
        {
            letter = "B";
            Console.Write(letter);
        }
        else if (score >= 90)
        {
            letter = "A";
            Console.Write(letter);
        }
        else
        {
            Console.WriteLine("Something went wrong.");
        }

        //Create if statement to determine if grade is '+', '-', or ' '.
        if (score >= 60 && score <64 || score >= 70 && score < 74 || score >= 80 && score < 84 || score >= 90 && score < 94)
        {
            Console.WriteLine("-");
        }
        else if (score >= 67 && score <70 || score >= 77 && score < 80 || score >= 87 && score < 90)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine(" ");
        }

        //Create if statement to display message based off score.
        if (score < 70)
        {
            Console.WriteLine("I'm sorry. You did not pass the course. Study hard and try again next time.");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Well done! You passed the course.");
        }
        else
        {
            Console.WriteLine("Something went wrong.");
        }

    }
}