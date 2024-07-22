
using System;

public class Cycling : Activity
{
    private int speed;

    public Cycling(DateTime date, int minutes, int speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public new int GetDistance() => (speed / 60) * Minutes;
    public new int GetSpeed() => speed;
    public new int GetPace() => 60 / speed;
}
