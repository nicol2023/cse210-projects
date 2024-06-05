using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new Running(new DateTime(2024, 6, 4), 30, 5.0),
            new Cycling(new DateTime(2024, 6, 4), 45, 15.0),
            new Swimming(new DateTime(2024, 6, 4), 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}