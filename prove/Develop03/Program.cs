using System;
using System.Collections.Generic;

public class Program
    
    
{
    public static void Main(string[] args)
    {   
        Scripture _scripture = new Scripture(new Reference("test", 2,1),"And it came to pass that in the first year");
       
        // write the scripture in terminal 
        // loop process 
        // prompt for enter 
        // clear console
        // hide some words
        // have a quit early 
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(_scripture.GetDisplayText());
            Console.WriteLine("Hit enter to continue or type quit to exit: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            if(_scripture.IsCompletlyHidden())
            {
                break;
            }
            _scripture.HideRandomWords(3);

        }



    }
}