class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to your Journal!");
        string choice;
        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Writing a new entry
                    string date = DateTime.Now.ToShortDateString();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your journal entry: ");
                    string entryText = Console.ReadLine();
                    journal.AddEntry(new Entry(date, prompt, entryText));
                    break;
                case "2":
                    // Displaying all entries
                    journal.DisplayAll();
                    break;
                case "3":
                    // Loading entries from file
                    Console.Write("Enter file path to load entries: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    // Saving entries to file
                    Console.Write("Enter file path to save entries: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5":
                    Console.WriteLine("See you later.");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != "5");
    }
}
