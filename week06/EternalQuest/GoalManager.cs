using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string answer = "";
        while (answer != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateGoal();
            }

            else if (answer == "2")
            {
                ListGoalDetaisl();
            }

            else if (answer == "3")
            {
                SaveGoals();
            }

            else if (answer == "4")
            {
                LoadGoals();
            }

            else if (answer == "5")
            {
                RecordEvent();
            }

            else if (answer == "6")
            {
                Console.WriteLine("Thank you. See you soon.");
            }

            else
            {
                Console.WriteLine("Please enter a valid menu option");
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        // index
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }

    }

    public void ListGoalDetaisl()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string answer = Console.ReadLine();

        Console.Write("what is the name of the Goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (answer == "1")
        {
            Goal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (answer == "2")
        {
            Goal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }

        else
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            Goal goal = new ChecklistGoal(name, description, points, bonus, 0, target);
            _goals.Add(goal);

        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you acomplish? ");
        int goal = int.Parse(Console.ReadLine());
        _goals[goal - 1].RecordEvent();
        int points = _goals[goal - 1].GetPoints();
        _score += points;
        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);

            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else
            {
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, bonus, amountCompleted, target);
                _goals.Add(goal);
            }
        }

    }

}