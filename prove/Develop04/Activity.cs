using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

public class Activity
{
    protected string _description;
    protected int _actDuration;
    protected string _activityName;

    public Activity()
    {
        _description = "";
        _actDuration = 0;
        _activityName = "Activity";
    }

    public void Display(bool isStart)
    {
        if (isStart)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}.");
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
            Console.WriteLine($"You have completed another {_actDuration} seconds of the {_activityName}");
            LogActivity();
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

    private void LogActivity()
    {
        string logEntry = $"{DateTime.Now}: Completed {_activityName} for {_actDuration} seconds.\n";
        File.AppendAllText("log.txt", logEntry);
        Console.WriteLine("(Your progress has been saved to log.txt)");
    }
}