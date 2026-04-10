using System;
namespace Mingfulness;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>

    {
     "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing Activity",
          "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10)
    { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---");
        ShowSpinner(5);
        Console.WriteLine("You have a few seconds to think...");
        ShowCountDown(8);

        Console.WriteLine("\nStart listing items (one per line). Time will run out automatically.\n");
        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }
    
    private string GetRandomPrompt()

    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser()
    {

        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                userList.Add(input);
            }
        }
        return userList;
    }   
    }
