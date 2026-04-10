using System;
namespace Mingfulness;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
     "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",10)

    {}
    
      public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nLet's start breathing...\n");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...   ");
            ShowCountDown(4);

            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out...  ");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }

    
}