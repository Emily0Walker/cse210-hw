using System;
using System.Collections.Generic;

public class Program
{
    public Scripture

    public static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
         string Text="For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        // Create a Scripture object
        Scripture scripture = new Scripture(Text);

        // Display the full scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Hide random words
        scripture.HideRandomWords(1);

        // Display the scripture with hidden words
        Console.WriteLine(scripture.GetDisplayText());
    }
}