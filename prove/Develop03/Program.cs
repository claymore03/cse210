//Name:Clayton Redding
//Course: CSE 210
//Instructor: Brother Parrish
//Date: 13 February 2025
using System;

class Program
{
    static void Main(string[] args)
    {
        var keyInfo = Console.ReadKey();
        
        string userInput = "";

        Console.WriteLine("Welcome to Scripture Memorizor 2000");

        Reference myReference = new Reference(1, "Nephi", 3, 7);
        Scripture myScripture = new Scripture();
        Word word = new Word();

        Console.WriteLine(myReference.ReferenceType1());
        myScripture.SetScripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(myScripture.GetScripture());

        myScripture.SeperateWords(myScripture.GetScripture());

        myScripture.JoinWords();

        myScripture.DeleteRandomWords();

        while (userInput != "quit" || myScripture.EndCondition() == false)
        {
            Console.WriteLine();
            userInput = Console.ReadLine();
            myScripture.DeleteRandomWords();
            myScripture.JoinWords();    
        
        }
    }
}