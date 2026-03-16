class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager(); // I created a negative goal system where points are deducted if the user performs that specific habit.
        manager.Start();
    }
}