using System;
using System.Collections.Generic;

public class Reflect : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflect() : base()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        _prompts = new List<string> 
        { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string> 
        { 
            "Why was this experience meaningful to you?", 
            "How did you feel when it was complete?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflect()
    {
        Display(true);
        Console.WriteLine("Consider the following prompt:");
        
        Random rand = new Random();
        Console.WriteLine($" --- {_prompts[rand.Next(_prompts.Count)]} --- ");
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_actDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {_questions[rand.Next(_questions.Count)]} ");
            Animate();
            Console.WriteLine();
        }
        Display(false);
    }
}