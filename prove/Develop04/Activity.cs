
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;



    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
    }


    protected void displayStartingMessage()
    {
        Console.Write ($"welcome to {_name}");
    }
    private void displayEndingMessage()
    { }
    private void showSpinner(int seconds)
    {        
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
 }
    private void showCountDown(int seconds)
    { 
        _count = count;
        Console.WriteLine();
    }
}

