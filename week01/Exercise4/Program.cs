using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (0 to finish): ");
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");

            string userResponse = Console.ReadLine();
            if (int.TryParse(userResponse, out number))
            {
                if (number != 0)
                {
                    numbers.Add(number);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");


            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("The smallest positive number is: (no numbers entered)");
        }
        else
        {
            long smallestSoFar = 99999999999L;

            bool foundPositive = false;
            foreach (int n in numbers)
            {
                if (n > 0 && n < smallestSoFar)
                {
                    smallestSoFar = n;
                    foundPositive = true;
                }
            }

            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallestSoFar}");
            }
            else
            {
                Console.WriteLine("The smallest positive number is: none found");
            }
        }
        List<int> sortedList = new List<int>(numbers);
        sortedList.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int n in sortedList)
        {
            Console.WriteLine(n);
        }
    }
    }

     


