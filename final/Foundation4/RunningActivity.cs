public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(float distance, string date, int lengthOfTime) : base(date,lengthOfTime)
    {
        _distance = distance;
    }

    public override float CalculateSpeed()
    {
        float speed = (_distance / GetLengthOfTime()) * 60;
        return speed;
    }

    public override float CalculatePace()
    {
        float pace = GetLengthOfTime() / _distance;
        return pace;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override string GetActivityInfo()
    {    
        return "Running";
    }
}