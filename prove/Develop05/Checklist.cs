public class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int pointsToReturn = int.Parse(_points);

        if (_amountCompleted == _target)
        {
            pointsToReturn += _bonus;
        }

        return pointsToReturn;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        return $"[{statusSymbol}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}