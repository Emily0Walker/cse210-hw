public class SimpleGoal : Goal
{
    public bool _IsComplete;

    public SimpleGoal(string name, string description, int arg1, int arg2)
        : base(name, description)
    {
      
    }

    public void RecordEvent()
    {
        // Implement the RecordEvent method logic here
        // For example:
        _IsComplete = true; // Set the goal as complete
    }

    public bool IsComplete()
    {
        return _IsComplete;
    }

    public string GetStringRepresentation()
    {
        // Implement a meaningful string representation
        return $"{Name}: {Description} (Complete: {_IsComplete})";
    }
}
