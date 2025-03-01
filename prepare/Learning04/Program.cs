//Name: Clayton Redding
//Instructor: Brother Parrish
//Course ID: CSE 210
//Date:03/01/2025
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        //Assignment class test case
        Assignment assignment1 = new Assignment();

        assignment1.SetName("Clayton Redding");
        assignment1.SetTopic("Fractions");
        
        Console.WriteLine(assignment1.DisplayAssignment());
        
        Console.WriteLine();

        //Math Assignment test case
        MathAssignment assignment2 = new MathAssignment();

        assignment2.SetName("Clayton Redding");
        assignment2.SetTopic("Multiplication");

        assignment2.SetSection("7.3");
        assignment2.SetProblems("1-12");

        Console.WriteLine(assignment2.DisplayAssignment());
        Console.WriteLine(assignment2.DisplayMathAssignment());

        Console.WriteLine();

        //Writing Assignment test case
        WritingAssignment assignment3 = new WritingAssignment();

        assignment3.SetName("Clayton Redding");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II by Mary Waters");

        Console.WriteLine(assignment3.DisplayAssignment());
        Console.WriteLine(assignment3.DisplayWritingAssignment());

    }
}