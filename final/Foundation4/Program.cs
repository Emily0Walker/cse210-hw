
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3),
            new Cycling(new DateTime(2022, 11, 3), 45, 15),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        activities.ForEach(activity => Console.WriteLine(activity.GetSummary()));

    }
}
