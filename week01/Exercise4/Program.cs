using System;

class Program
{
    static void Main(string[] args)
    {

        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            List<int> numbers = new List<int>();
            int number = -1;

            while (number != 0)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out number))
                {
                    if (number != 0)
                    {
                        numbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                    number = -1; 
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
            }
            else
            {
                Console.WriteLine("The average is: undefined (no numbers entered)");
            }

            
            if (numbers.Count == 0)
            {
                Console.WriteLine("The largest number is: (no numbers entered)");
            }
            else
            {
                int bestSoFar = -1;   

                foreach (int n in numbers)
                {
                    if (n > bestSoFar)
                    {
                        bestSoFar = n;
                    }
                }

                Console.WriteLine($"The largest number is: {bestSoFar}");
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

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}