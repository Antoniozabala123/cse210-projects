using System;
namespace Mingfulness;

public class Activity
{
    //private string _name, _description;: Private fields that store the name and explanation of each activity.
    //private int _duration;: Stores how many seconds the session will last.
    //public Activity(...): This is the constructor. It is responsible for assigning initial values ​​when you create a new activity.
    private string _name;
    private string _description;
    private int _duration;



    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    
    public void DisplayStartingMessage()
    {
        //Clear the screen and display the welcome message.
        Console.Clear();
        Console.WriteLine($"=== Welcome to {_name} ===\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds do you want to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready! The activity will begin in a few seconds...");
        ShowSpinner(5);
    }
    //Congratulate the user and confirm how many seconds they spent on the activity. Use the spinner several times to give a sensation of "loading" or gentle closing.
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the activity of{_name} By {_duration} Second.");
        ShowSpinner(5);
        Console.WriteLine("\nThank you for taking time for yourself! ");
        ShowSpinner(3);
    }
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int i = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
        Console.Write(" ");
        Console.WriteLine();
    }
    // Calculate when to finish
    public static void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (i >= 10) Console.Write("\b");
        }
        Console.WriteLine();
    }
    
} 

