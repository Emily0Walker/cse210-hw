using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string filePath = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nWelcome to Eternal Quest");
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. Check goal details");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Exit");
            Console.Write("Choose your option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(goalManager);
            }
            else if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                goalManager.SaveGoals(filePath);
                Console.WriteLine("Goals saved successfully.");
            }
            else if (choice == "4")
            {
                goalManager.LoadGoals(filePath);
                Console.WriteLine("Goals loaded successfully.");
            }
            else if (choice == "5")
            {
                break; // Exit the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}  

  