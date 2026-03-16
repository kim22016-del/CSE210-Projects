public class Negative : Goal
{
    public Negative(string name, string description, string points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -int.Parse(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}