using System;

public class Breathe : Activity
{
    private int _in;
    private int _out;

    public Breathe() : base()
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _in = 4;
        _out = 6;
    }

    public void RunBreathe()
    {
        Display(true);
        DateTime endTime = DateTime.Now.AddSeconds(_actDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(_in);
            Console.Write("Now breathe out... ");
            Countdown(_out);
            Console.WriteLine();
        }
        Display(false);
    }
}