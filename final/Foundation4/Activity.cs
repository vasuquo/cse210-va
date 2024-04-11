public class Activity
{
    private string _date;
    private int _lengthOfTime;

    public Activity(string date, int lengthOfTime)
    {
        _date = date;
        _lengthOfTime = lengthOfTime;

    }

    public string GetSummary()
    {
        string summaryString = $"{_date} {GetActivityInfo()} ({_lengthOfTime}min); Distance {CalculateDistance()}Km, Speed {CalculateSpeed()}Kph, Pace {CalculatePace()}min per Km";
        return summaryString;
    }

    public int GetLengthOfTime()
    {
        return _lengthOfTime;
    }

    public virtual float CalculateSpeed()
    {
        return 0f;
    }
    public virtual float CalculatePace()
    {
        return 0f;
    }
    public virtual float CalculateDistance()
    {
        return 0f;
    }
    public virtual string GetActivityInfo()
    {
        return " ";
    }
}