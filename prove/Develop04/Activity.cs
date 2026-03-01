using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _description;
    protected int _actDuration;

    public Activity()
    {
        _description = "";
        _actDuration = 0;
    }

    public void Display(bool isStart)
    {
        if (isStart)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Activity.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            _actDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            Animate();
        }
        else
        {
            Console.WriteLine("\nWell done!!");
            Animate();
            Console.WriteLine($"You have completed another {_actDuration} seconds of the Activity.");
            Animate();
        }
    }

    public void Animate()
    {
        List<string> animationList = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationList[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationList.Count) i = 0;
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}