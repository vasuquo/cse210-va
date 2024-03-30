public class SelfRelianceGoal : Goal
{
    private List<string> _goalTypes = new List<string>();
    private List<int> _bonus = new List<int>();
    private int _duration;

    private int _index;

    public SelfRelianceGoal(string shortName, string description, int point, int duration, int index) : base(shortName, description, point)
    {
        _goalTypes.Add("PersonalFinance");
        _goalTypes.Add("EducationForBetterJob");
        _goalTypes.Add("FindBetterJob");

        _bonus.Add(500);
        _bonus.Add(700);
        _bonus.Add(900);

        _duration = duration;
        _index = index;

    }

    public override string GetDetailsString()
    {
        string detailString = $"{GetShortName()} ({GetDescription()})";
        string subDetails = "\nSelf Reliance Options:";
        string checkIt = " ";
        for (int i=0; i<_goalTypes.Count; i++)
        {
            if (_duration == 0 && i == _index)
            {
                checkIt = "X";
            }
            else
            {
                checkIt = " ";
            }
            subDetails += $"\n {i+1}. [{checkIt}] {_goalTypes[i]}";            
        }
        return detailString + subDetails;        
    }


    public override void RecordEvent()
    {
        for (int i = 0; i < _goalTypes.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goalTypes[i]}");            
        }
        Console.Write("Select one of the above: ");
        int option = int.Parse(Console.ReadLine());  

        Console.WriteLine($"Hurray You a bonus of {_bonus[option-1]}.");
        _duration = 0;
        SetPoints(GetPoints()+_bonus[option-1]);  
        _index = option-1;   
        
    }
    public override bool IsComplete()
    {
        if (_duration > 0) 
        {
           return false;
        }
        return true;

    }

    public override string GetStringPresentation()
    {
        return $"SelfRelianceGoal:{GetShortName()}:{GetDescription()}:{GetPoints()}:{_duration}:{_index}";
    }


}