//Name: Clayton Redding
//Date: 01/15/2025
//Course: CSE 210
//Professor: Brother Parrish
using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcomeMessage();
       string name = PromptUserName();
       double favNum = PromptUserNumber();
       double squaredNum = SquareNumber(favNum);
       DisplayResults(name, squaredNum); 
       
       static void DisplayWelcomeMessage()
       {
        Console.WriteLine("Welcome to the program!");
       }
       
       static string PromptUserName()
       {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
       }
       
       static double PromptUserNumber()
       {
        Console.Write("Enter your favorite number: ");
        double userNumber = double.Parse(Console.ReadLine());
        return userNumber;
       }
       
       double SquareNumber(double number)
       {
        double squared = Math.Pow(number, 2);
        return squared;
       }

       static void DisplayResults(string name, double num)
       {
        Console.WriteLine(name+", the square of your number is "+num);
       }

    }
}