public class SimpleGoal : Goal
{
    public bool _IsComplete;

    public SimpleGoal(string name, string description, int arg1, int arg2)
        : base(name, description)
    {
      
    }

    public void RecordEvent()
    {
        // save in csv ot txt file
        _IsComplete = true; 
    }

    public bool IsComplete()
    {
        return _IsComplete;
    }

    public string GetStringRepresentation()
    {
       
        return $"{name}: {description} Complete: {_IsComplete}"
    }
}
