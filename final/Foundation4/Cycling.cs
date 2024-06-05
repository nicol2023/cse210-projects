using System;

public class Cycling : Activity
{
    private double _distance;

    public Cycling(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / GetLength()) * 60;
    public override double GetPace() => GetLength() / _distance;
}