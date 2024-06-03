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

    //public int GetTotalPoints()
    //{
        //int total = GetPoints(); 
        //total += _bonus;
        //return total;//
    //}//

    public override int RecordEvent()
    {
        _amountCompleted ++;

        if (_amountCompleted >= _target)
        {
            int totalPoints = _points + _bonus;  // Sumar puntos y bono solo si está completo
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
        return _amountCompleted >= _target;
        //bool complete = false;
        //if (_amountCompleted == _target)
        //{
            //complete = true;
        //}
        //return  complete;//
    }

    public override string GetDetailsString()
    {
        string complete = IsComplete() ? "x" : " ";
        return $"[{complete}] {GetName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}.";
        
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}~{GetDescription()}~{GetPoints()}~{_target}~{_bonus}~{_amountCompleted}";
    }
}