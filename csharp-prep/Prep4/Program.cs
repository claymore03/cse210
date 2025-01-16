using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput;
        Console.WriteLine("Enter a number: ");
        userInput = int.Parse(Console.ReadLine());
        numbers.Add(userInput);

        while (userInput != 0)
        {
            Console.WriteLine("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            numbers.Add(userInput);
        }

        int sum = numbers.Sum();
        Console.WriteLine("The sum is: " + sum);

        float average = sum/numbers.Count();
        Console.WriteLine("The average is: " + average);

        int maxNum = numbers.Max();
        Console.WriteLine("The largest number is: " + maxNum);
    }
}