using System;
using System.Collections.Generic;

public class ListActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListActivity() : base()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> 
        { 
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public void RunList()
    {
        Display(true);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        
        Random rand = new Random();
        Console.WriteLine($" --- {_prompts[rand.Next(_prompts.Count)]} --- ");
        
        Console.Write("You may begin in: ");
        Countdown(3);

        DateTime endTime = DateTime.Now.AddSeconds(_actDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        Display(false);
    }
}