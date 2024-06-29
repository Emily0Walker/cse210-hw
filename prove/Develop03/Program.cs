using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Example reference
        Reference reference = new Reference("John", 3, 16);

        // Example scripture text
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create a Scripture object
        Scripture scripture = new Scripture(reference, text);

        // Display the full scripture
         Console.WriteLine(reference.ToString());
        Console.WriteLine(text);
        Console.WriteLine(scripture.GetDisplayText());

        // Hide random words
        scripture.HideRandomWords(1);
        // Display the scripture with hidden words
        Console.WriteLine("\nScripture with hidden words:");
        Console.WriteLine(scripture.GetDisplayText());            

        // Check if all words are hidden
        bool allHidden = scripture.IsCompletelyHidden();
        Console.WriteLine($"\nAll words hidden: {allHidden}");
    }
}