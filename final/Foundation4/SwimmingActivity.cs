public class SwimmingActivity : Activity
{
    private int _noOfLaps;

    public SwimmingActivity(int noOfLaps, string date, int lengthOfTime )  : base(date, lengthOfTime)
    {
        _noOfLaps = noOfLaps;
    }

    public override string GetActivityInfo()
    {
        return "Swimming";
    }

    public override float CalculateDistance()
    {
        float distance = _noOfLaps * 50 / 1000;
        return distance;
    }

    public override float CalculateSpeed()
    {
        float speed = (CalculateDistance() / GetLengthOfTime()) * 60;
        return speed;
    }

    public override float CalculatePace()
    {
        float pace = GetLengthOfTime() / CalculateDistance();
        return pace;
    }

    
}