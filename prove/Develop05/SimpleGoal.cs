using System;

public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base.GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string text = $"SimpleGoal:{base.GetName()}~{base.GetDescription()}~{base.GetPoints()}~{IsComplete()}";
        return text;
    }
}