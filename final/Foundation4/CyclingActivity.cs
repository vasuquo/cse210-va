public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(float speed,string date, int lengthOfTime) : base(date, lengthOfTime)
    {
        _speed = speed;
    }

    public override string GetActivityInfo()
    {
        return "Cycling";
        
    }

    public override float CalculateSpeed()
    {        
        return _speed;
    }

    public override float CalculateDistance()
    {
        float distance = _speed * GetLengthOfTime();
        return distance;
    }

    public override float CalculatePace()
    {
        float pace = GetLengthOfTime() / CalculateDistance();
        return pace;
    }

}