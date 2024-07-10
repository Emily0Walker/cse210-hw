public class breathingActivity
{

    public breathingActivity (name, description, duration)
       : base(name, description, duration)
    {
        name = "Breathing Activity";
        description = "Breathing in and out slowly will help you relax by slowing your brain and your heartbeat";

        Console.WriteLine("How long do you want to do this activity for (seconds): ");
        string _duration = Console.ReadLine();

        // Parse the input duration to an integer
        
        if (int.TryParse(_duration, out _duration))
        {
            Console.WriteLine("Testing duration now");

            // Sleep for the specified duration (converted to milliseconds)
            Thread.Sleep(duration * 1000);

            Console.WriteLine("Activity completed.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");

        }

        


    }
}
