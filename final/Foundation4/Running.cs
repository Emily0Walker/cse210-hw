
using System;

public class Running : Activity
{
    private int distance;

    public Running(DateTime date, int minutes, int distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public new int GetDistance() => distance;
    public new int GetSpeed() => (distance / Minutes) * 60;
    public new int GetPace() => Minutes / distance;
}