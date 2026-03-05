using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage ? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        // # Handle the A+ grades
        if (percent >= 93)
        {
            sign = "";
        }
        if (percent < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign} ");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}
