public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, string isComplete) : base(shortName, description, points)
    {
        _isComplete = bool.Parse(isComplete);
    }

    public override void RecordEvent()
    {
        _isComplete = true;

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringPresentation()
    {
        return $"SimpleGoal:{GetShortName()}:{GetDescription()}:{GetPoints()}:{_isComplete}";
    }

}