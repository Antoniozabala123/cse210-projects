using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        //ask the use for their name.
        Console.WriteLine("What is your first name?");
        string First = Console.ReadLine();

        Console.Write("what is your last name? ");
        String Last = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {First}, {First} {Last}.");
    }
}