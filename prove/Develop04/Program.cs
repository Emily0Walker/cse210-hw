using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reseting is the key to success");
        Console.WriteLine("1.) Breathing");
        Console.WriteLine("2.) listing ");
        Console.WriteLine("3.) prompt journaling");
        Console.WriteLine(" - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("how do you want to reset today:");
        string choice = Console.ReadLine(); // take int input from user 

        //Execute an activity if number matches options
        
        if ( choice == "1") // BreathingActivity
        {
                Console.Clear();
                //

        }
        else if (choice == "2") // ListingActivity
        {
                Console.Clear();
                //
        }
        else if (choice =="3") // ReflectionActivity
        {
                Console.Clear();
                //
        }
        else // not an option thing
        {}




        //if statement to find class to run through 

                    //displays activity name for 5 secs
                    //clear console
                    // Displays instructions
                    // asks for how long theyed like to do it for
                    // uses that number in the duration method
                    // Displays a message indicating the activity is about to begin
                    // Shows spinner animation for 5 seconds
                    // Starts the counting process
                    // Displays a happy completion message
                    // Clears the console
                    // Returns to the display

            // listing activity run
                    
                    // Displays the activity name for 5 seconds
                    // Clears the console
                    // Displays user instructions
                    // asks for how long theyed like to do it for
                    // uses that number in the duration method
                    // Clears the console
                    // Displays a random prompt from the prompt list
                    // Displays a "ponder on" message
                    // Shows spinner animation indicating a loading or waiting period
                    // Clears the console
                    // Displays the start message
                    // Clears the console
                    // Displays the prompt
                    // Starts the countdown timer
                    // Prompts the user for input
                    // Each Enter key press increments the number on the side for the list number
                    // Countdown timer expiration disables user input
                    // *Optional: Saves the list to a .txt 
                    // gives happy completion message
                    // Clears the console
                    // Returns to the main menu


            // reflection activity run through
                    
                    // Displays the activity name for 5 seconds
                    // Clears the console
                    // Displays user instructions
                    // asks for how long theyed like to do it for
                    // uses that number in the duration method
                    // Clears the console
                    // Displays a random prompt from the prompt list
                    // Displays a "ponder on" message
                    // Shows spinner animation indicating a loading or waiting period
                    // Clears the console
                    // Displays the start message
                    // Clears the console
                    // Displays the prompt
                    // Starts the countdown timer
                    // Allows the user to write
                    // Countdown timer expiration disables user input
                    // *Optional: Saves the list to a .txt file
                    // Displays a happy completion message
                    // Clears the console
                    // Returns to the main menu


    }
}