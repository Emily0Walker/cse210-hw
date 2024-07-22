
using System;

public class Activity
{
    public DateTime Date { get; }
    public int Minutes { get; }

    protected Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public int GetDistance() => 0;
    public int GetSpeed() => 0;
    public int GetPace() => 0;

    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile\n";
    }
}