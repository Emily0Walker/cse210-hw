    // starting message 
      
        Console.WriteLine($"{name}");
        Thread.Sleep(5000);
        Console.Clear();
        Console.WriteLine($"{description}");
        Thread.Sleep(10000);
        Console.Clear();
        
        Console.WriteLine("How long do you want to do this activity? (seconds): ");
        string userDuration = Console.ReadLine();

        Console.WriteLine("The activity will start in one moment");