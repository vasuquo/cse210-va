public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int bonus, int target, int amountCompleted) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                SetPoints(GetPoints()+_bonus);            
            }
            
        }        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;        
    }

    public override string GetDetailsString()
    {
        string detailString = $"{GetShortName()} ({GetDescription()}) -- currently completed: {_amountCompleted}/{_target}";
        return detailString;        
    }

    public override string GetStringPresentation()
    {
        return $"CheckListGoal:{GetShortName()}:{GetDescription()}:{GetPoints()}:{_bonus}:{_target}:{_amountCompleted}";
    }
}