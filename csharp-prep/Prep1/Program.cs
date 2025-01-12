//Name: Clayton Redding
//Date: 01/11/2025
//Course: CSE 210
//Professor: Brother Parrish
using System;

class Program
{
    static void Main(string[] args)
    {
        //Create variables for the first name and last name.
        string firstName;
        string lastName;
        
        //Ask user to input a first name.
        Console.WriteLine("Enter your first name: ");
        firstName = Console.ReadLine();
        //Ask user to input a last name.
        Console.WriteLine("Enter your last name: ");
        lastName = Console.ReadLine();
        //Display the last name, then the first and last name together.
        Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName + ".");

    }
}