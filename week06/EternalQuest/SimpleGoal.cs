using System.Diagnostics;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            Console.WriteLine($"Congratulations, you have earned {_points} points");
            _isComplete = true;
        }
        else
        {
            _points = 0;
            Console.WriteLine("You already completed this goal");
        }
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}