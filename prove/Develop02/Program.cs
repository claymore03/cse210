//Name:Clayton Redding
//Course: CSE 210
//Instructor: Brother Parrish
//Date: 31 January 2025
using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Console.WriteLine("Welcome to Journaltron 2000");
        Console.WriteLine("1. Write.\n2. Display.\n3. Load.\n4. Save.\n5. Quit\n");
        Console.Write("Select an option: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        while (selection != 5){
            if (selection == 1)
            {
                //Write a new entry
                string entry = "";
                string prompt = "";
                prompt = myJournal.RandomPrompt();
                Entry entry1 = new Entry(prompt, entry);
                Console.WriteLine(prompt);
                entry1.WriteNewEntry();
                myJournal._entriesList.Add(entry1);
            }
            else if (selection == 2)
            {
                //Display entries
                myJournal.DisplayEntries();
            }
            else if (selection == 3)
            {
                //Load journal
                myJournal.LoadFile();
            }
            else if (selection == 4)
            {
                //Save journal
                myJournal.SaveToFile(myJournal._entriesList);
            }
            else
            {
                Console.WriteLine("Invalid selection! Please, select a number between 1 and 5.");
            }

            Console.WriteLine("1. Write.\n2. Display.\n3. Load\n4. Save.\n5. Quit\n");
            Console.Write("Select an option: ");
            selection = Convert.ToInt32(Console.ReadLine());
        }
    }
       
}