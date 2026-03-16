using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string menuSelection = "";
        while (menuSelection != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuSelection = Console.ReadLine();

            if (menuSelection == "1")
            {
                CreateGoal();
            }
            else if (menuSelection == "2")
            {
                ListGoalDetails();
            }
            else if (menuSelection == "3")
            {
                SaveGoals();
            }
            else if (menuSelection == "4")
            {
                LoadGoals();
            }
            else if (menuSelection == "5")
            {
                RecordEvent();
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (goalType == "1")
        {
            _goals.Add(new Simple(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new Eternal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new Checklist(name, description, points, target, bonus));
        }
        else if (goalType == "4")
        {
            _goals.Add(new Negative(name, description, points));
        }
    }

public void RecordEvent()
{
    ListGoalDetails();
    Console.Write("Which goal did you accomplish? ");
    int goalIndex = int.Parse(Console.ReadLine()) - 1;

    int pointsEarned = _goals[goalIndex].RecordEvent();
    _score += pointsEarned;

    Console.WriteLine($"You have earned {pointsEarned} points!");
    Console.WriteLine($"You now have {_score} points.");
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
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(filename);
    _score = int.Parse(lines[0]);

    _goals.Clear(); 

    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(':');
        string type = parts[0];
        string details = parts[1];
        string[] data = details.Split(',');

        if (type == "Simple")
        {
            Simple goal = new Simple(data[0], data[1], data[2]);
            if (bool.Parse(data[3]))
            {
                goal.RecordEvent();
            }
            _goals.Add(goal);
        }
        else if (type == "Eternal")
        {
            _goals.Add(new Eternal(data[0], data[1], data[2]));
        }
        else if (type == "Checklist")
        {
            int bonus = int.Parse(data[3]);
            int target = int.Parse(data[4]);
            int current = int.Parse(data[5]);

            Checklist goal = new Checklist(data[0], data[1], data[2], target, bonus);
            for (int j = 0; j < current; j++)
            {
                goal.RecordEvent();
            }
            _goals.Add(goal);
        }
    }
}
}