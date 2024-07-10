public class GoalManager
{
    public string Name;
    public string Description;
    public int Points; 
    public bool IsComplete;

    public virtual void RecordEvent()
    {
        IsComplete = true;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{Name}|{Description}|{Points}|{IsComplete}";
    }
}

