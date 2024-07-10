public class EternalGoal
{
    // Properties
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    // Constructor
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false; // Initial state
    }

    // Method to record an event
    public void RecordEvent()
    {
        // Logic to handle the recording of an event
       
        _isComplete = true; 
    }

    // Method to check if the goal is complete
    public bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get a string representation of the goal
    public string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nPoints: {_points}\nCompleted: {_isComplete}";
    }
}
