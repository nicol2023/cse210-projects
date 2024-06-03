using System;
using System.IO;
using System.Collections.Generic;
public class GoalManager 
{
    public List<Goal> _goals =new List<Goal>();
    public int _score;

    public GoalManager()
    {
        _goals.Clear();
        _score=0;
    }

    public void SetScore (int score)
    {
        _score=score;
    }

    public int GetScore()
    {
        return _score;
    }

    public void Start()
    {
        Console.WriteLine($"\n*** You have {_score} points ***\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create a new Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Gols");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("select an option from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\nThe type of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of Goal would  you like to create?");
    }

    public void ListGoalNames()
    {
        int index =0;    
        foreach (Goal goal in _goals)
        {
            index +=1;
            Console.WriteLine($"{index}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            index += 1;
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
        } 
    }

    public void CreateGoal(string goalType)
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the ammount of points associated whit the goal? ");
        int goalPoints = Convert.ToInt32(Console.ReadLine());

        if (goalType == "simple")
        {
            SimpleGoal simple =new SimpleGoal(goalName, goalDescription, goalPoints); 
            _goals.Add(simple);
        }
        else if (goalType == "eternal")
        {
            EternalGoal eternal =new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternal);
        }
        else if (goalType == "checklist")
        {
            Console.Write("How many times does this goal need to be acomplished for a bonus? ");
            int target= Convert.ToInt32(Console.ReadLine());

            Console.Write("How is the bonus for acomplishing it that many times? ");
            int bonus= Convert.ToInt32(Console.ReadLine());

            ChecklistGoal checklist =new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            _goals.Add(checklist);
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which Goal do you want to accomplish? ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1; // Subtract 1 to fit with the list index

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;

            if (goal.IsComplete())
            {
                Console.WriteLine($"Goal '{goal.GetName()}' completed! You have {_score} points now.");
            }
            else
            {
                Console.WriteLine($"Event recorded for goal '{goal.GetName()}'. You have {_score} points now.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals(string filename)
    {
       using (StreamWriter userFile = new StreamWriter(filename))
        {
            userFile.WriteLine($"Score:{_score}");

            foreach(Goal goal in _goals)
            {
                userFile.WriteLine(goal.GetStringRepresentation());  
            }  
        } 
    }

    public void LoadGoals(string filename)
    {
      _goals.Clear();
      string[] lines = System.IO.File.ReadAllLines(filename);

      foreach (string line in lines)
      {
        string[] parts = line.Split("~");
        string[] heading = parts[0].Split(":");
        string goalType = heading[0];

        if (goalType == "Score")
        {
            _score = Convert.ToInt32(heading[1]);
            continue;
        }

        if (parts.Length < 3)
        {
            Console.WriteLine("Invalid line format, skipping line.");
            continue;
        }

        string goalName = heading[1];
        string goalDescription = parts[1];
        int goalPoints = Convert.ToInt32(parts[2]);

        if (goalType == "SimpleGoal")
        {

            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoints);
            if (parts[3] == "True")
            {
                simple.RecordEvent();
            }
            _goals.Add(simple);
        }

        else if (goalType == "EternalGoal")
        {
            EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternal);
        }

        else if (goalType == "CheckListGoal")
        {

            int bonus = Convert.ToInt32(parts[3]);
            int target = Convert.ToInt32(parts[4]);
            ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            checklist.SetAmount(Convert.ToInt32(parts[5]));
            _goals.Add(checklist);
        }
      }  
    }
}