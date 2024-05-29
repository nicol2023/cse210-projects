using System;

public class ChecklistGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description , int points, int target, int bonus) : base(name, description, points)
    {
        _target=target;
        _bonus= bonus;
        _amountCompleted = 0;
    }

    public void SetAmount(int ammount)
    {
        _amountCompleted = ammount;
    }

    public int GetTotalPoints()
    {
        int total = GetPoints(); 
        total += _bonus;
        return total;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;

        if (IsComplete())
        {
            int totalPoints = GetTotalPoints();
            SetPoints(totalPoints);
            Console.WriteLine($"Congratulations, you have earned {totalPoints} points!!!");
            return totalPoints;
        }
        else
        {
            Console.WriteLine($"You have earned {_points} points.");
            return _points;
        }
    }

    public override bool IsComplete()
    {
        bool complete = false;
        if (_amountCompleted == _target)
        {
            complete = true;
        }
        return  complete;
    }

    public override string GetDetailsString()
    {
        string complete =" ";
        bool isComplete = IsComplete();
        if (isComplete==true)
        {
            complete="x";
        }

        string text = $"[{complete}] {base.GetName()} ({base.GetDescription()}) -- Curretly completed {_amountCompleted}/{_target}."; 
        return text;
    }

    public override string GetStringRepresentation()
    {
        string text = $"CheckListGoal:{base.GetName()}~{base.GetDescription()}~{base.GetPoints()}~{_bonus}~{_target}~{_amountCompleted}";
        return text;
    }
}