public class Goal
{
    private string _shortname;
    private string _description;
    private int _points;
    private bool _isComplete;


    public Goal()
    {
        _shortname = string.Empty;
        _description = string.Empty;
        _points = 0;
        _isComplete = false;
    }

  
    public Goal(string shortname, string description, int points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Record an event
    public void RecordEvent()
    {
        // Logic to handle the recording of an event
        _isComplete = true;
    }

    // Check if the goal is complete
    public bool IsComplete()
    {
        return _isComplete;
    }

    
    public string GetDetailsString()
    {
        return $"Goal: {_shortname}\nDescription: {_description}\nPoints: {_points}\nCompleted: {_isComplete}";
    }

   
    public string GetStringRepresentation()
    {
        return $"{_shortname}|{_description}|{_points}|{_isComplete}";
    }
}
