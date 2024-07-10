public class breathingActivity
{

    public BreathingActivity(string name, string description, int duration)
       : base(name, description, duration)
    {
        name = "Breathing Activity";
        description = "Breathing in and out slowly will help you relax by slowing your brain and your heartbeat";

        Console.WriteLine("How long do you want to do this activity for (seconds): ");
        string _duration = Console.ReadLine();

        // Parse the input duration to an integer
        int _duration;
        if (int.TryParse(_duration, out duration))
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

        public void run()
        {
            base.displayStartingMessage();
        }


    }
