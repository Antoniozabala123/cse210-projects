using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        //ask the use for their name.
        Console.WriteLine("What is your first name?");
        string First = Console.ReadLine();
        // ask the user for last name
        Console.Write("what is your last name? ");
        String Last = Console.ReadLine();

        Console.WriteLine();

        // prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name" as shown:
        Console.WriteLine($"Your name is {Last}, {First} {Last}.");
    }
}