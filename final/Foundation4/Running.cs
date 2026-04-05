public class Running : Activity
{
    private double _distance;

    public Running(string name, string date, int minutes, double distance) : base(name, date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / _distance;
}