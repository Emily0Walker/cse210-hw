
using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public new int GetDistance() => (laps * 50) / 1609;
    public new int GetSpeed() => (GetDistance() / Minutes) * 60;
    public new int GetPace() => Minutes / GetDistance();
}
