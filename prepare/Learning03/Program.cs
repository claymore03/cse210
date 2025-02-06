using System;

class Program
{
    static void Main(string[] args)
    {
        //Default fraction (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.DisplayFractionString());
        Console.WriteLine(f1.CalculateDecimalValue());

        //Whole number in fraction form (7/1)
        Fraction f2 = new Fraction(7);
        Console.WriteLine(f2.DisplayFractionString());
        Console.WriteLine(f2.CalculateDecimalValue());

        //Regular Fraction
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.DisplayFractionString());
        Console.WriteLine(f3.CalculateDecimalValue());

        //Regular Fraction
        Fraction f4 = new Fraction(2, 9);
        Console.WriteLine(f4.DisplayFractionString());
        Console.WriteLine(f4.CalculateDecimalValue());
        

    }
}