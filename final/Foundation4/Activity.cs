using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity( DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_length} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }

    protected DateTime GetDate() => _date;
    protected int GetLength() => _length;
}   

