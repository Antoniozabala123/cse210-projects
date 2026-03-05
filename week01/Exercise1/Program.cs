using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        //ask the use for their name.
        Console.WriteLine("What is your first name?");
        string first = Console.ReadLine();

        Console.Write("what is your last name? ");
        String last = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {first}, {first} {last}.");
    }
}