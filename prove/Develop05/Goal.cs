using System;

public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string complete =" ";
        bool isComplete = IsComplete();
        if (isComplete==true) 
        {
            complete="x";
            //
            //string text = $"[{complete}] {_shortName} ({_description}) ";//
        }
        string text = $"[{complete}] {_shortName} ({_description}) ";
        return text;
        
    }

    public abstract string GetStringRepresentation();
}