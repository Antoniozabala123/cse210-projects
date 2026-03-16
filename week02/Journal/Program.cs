using System;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        PromptGenerator generator = new PromptGenerator();


        Console.WriteLine("Welcome to the journal program! ");

        //Provide a menu that allows the user choose these options
        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an option");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine("Prompt: " + prompt);
                Console.Write($"Date {DateTime.Now} ");
                string entryText = Console.ReadLine() ?? "";

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString(),
                    _promptText = prompt,
                    _entryText = entryText
                };

                thejournal.AddEntry(newEntry);
                Console.WriteLine("Entry added! Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                thejournal.DisplayAll();

                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                string filename = "people.txt";
                
                using (StreamWriter outputfile = new StreamWriter(filename))

                thejournal.SaveToFile(filename);
                Console.WriteLine("Journal saved. Press Enter...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine()?.Trim();
                
                {
                    filename = "journal.txt";
                }

                thejournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded. Press Enter...");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye! Thanks for using the journal.");

            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1-5.");
                Console.WriteLine("Press Enter to try again...");
                Console.ReadLine();
            }
        }
    }
}

