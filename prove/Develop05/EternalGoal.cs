using System;

public class EternalGoal : Goal 
{
    public EternalGoal (string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return base.GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string text = $"EternalGoal:{base.GetName()}~{base.GetDescription()}~{base.GetPoints()}";
        return text;
    }
}