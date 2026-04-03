using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {

        // 1. this  first part
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the lord all thine heart and lean not unto thine own understanding in all thy wat acknowledge him, and he shall direct thy paths.");

        string input = "";

        // 2. Bucle 
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            string date = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine($"date to practice: {date}");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\npresss enter to continue or type 'quit' to finish:");



            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(1); // hide word
            }
        }

        // finish program quit 
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nthis programs is over.");
    }

}