public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, string date, int minutes, double speed) : base(name, date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance() => (_speed * GetMinutes()) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}