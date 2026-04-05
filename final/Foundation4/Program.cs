using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Running", "01 April 2026", 30, 5));
        activities.Add(new Cycling("Cycling", "02 April 2026", 30, 20));
        activities.Add(new Swimming("Swimming","03 April 2026", 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}