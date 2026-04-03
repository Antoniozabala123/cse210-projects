using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)

    {
        //For this assignment, write a C# program that has several simple functions:
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }

        //DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        //PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int UserNumber = int.Parse(Console.ReadLine());
            return UserNumber;
        }
        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int SquareNumber = number * number;
            return SquareNumber;
        }
        //DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int SquareNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {SquareNumber}");
        }
    }
}