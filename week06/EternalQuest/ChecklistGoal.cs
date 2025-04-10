public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int bonus, int amountCompleted, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _target = target;


    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            Console.WriteLine($"Congratulations, you have earned {_points} points");
            _amountCompleted++;

            if (IsComplete())
            {
                _points += _bonus;
                Console.WriteLine($"Congratulations!!! You have also obtained a bonus of {_bonus} points for completing this goal!!! ");
            }

            else
            {
                Console.WriteLine("You already completed this goal");
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string GetDetailsString()
    {
        string completed = " ";

        if (IsComplete())
        {
            completed = "X";
        }

        return $"[{completed}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_amountCompleted}|{_target}";
    }

}
