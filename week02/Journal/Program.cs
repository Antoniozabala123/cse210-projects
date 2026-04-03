using System;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        // Write a new entry - Show the user a random prompt(from a list that you create), and save their response, the prompt, and the date as an Entry.

        //Display the journal - Iterate through all entries in the journal and display them to the screen.
        //Save the journal to a file -Prompt the user for a filename and then save the current journal(the complete list of entries) to that file location.
        //Load the journal from a file -Prompt the user for a filename and then load the journal(a complete list of entries) from that file.This should replace any entries currently stored the journal.
        //Provide a menu that allows the user choose these options
        //Your list of prompts must contain at least five different prompts.Make sure to add your own prompts to the list, but the following are examples to help get you started:
        // 1. Dynamic File Management: The logic was corrected so that the user can choose custom filenames or use the default.
        // 2.Error Validation: A physical check(File.Exists) was added before loading, preventing the program from becoming true.
        // Data Formatting: A special delimiter (||) is used to ensure that if the user enters commas, the file is not corrupted.

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
            //The first option, using the get random Prompts method, generates a random question from this Generator Prompts file.
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
            //It iterates through the list and displays all entries. If it is empty, it notifies the user.
            else if (choice == "2")
            {
                thejournal.DisplayAll();

                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
            }
            // people can save up comment in archive txt 

            else if (choice == "3")
            {
                Console.Write("Save as: ");
                string filename = Console.ReadLine();

                if (string.IsNullOrEmpty(filename))

                {
                    filename = "people.txt";

                }

                thejournal.SaveToFile(filename);
                Console.WriteLine("Journal saved. Press Enter...");
                Console.ReadLine();
            }
            //Check if the file physically exists on the disk
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(filename))
                {
                    filename = "people.txt";
                }

                thejournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded. Press Enter...");
                Console.ReadLine();
            }
            // option finishing program for user

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