
    public class SimpleGoal : Goal
    {
        private bool _IsComplete;

        public SimpleGoal(string name, string description)
            : base(name, description)
        {
            _IsComplete = false;
        }

        public new void RecordEvent()
        {
            // save in csv or txt file
            _IsComplete = true;
        }
    }

    public bool IsComplete()
    {
        return _IsComplete;
    }

    public string GetStringRepresentation()
    {
        return $"{name}: {description} Complete: {_IsComplete}";
    }
}
