public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {        
        _score = 0;
    }

    public void Start()
    {        
        string option = "0";

        while (option != "6") 
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");  
            Console.WriteLine("  4. Load Goals");   
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {                                                            
                ListGoalNames();
                CreateGoal();                
            }
            else if (option == "2")
            {                
                ListGoalDetails();
            }
            else if (option == "3")
            {                
                SaveGoal();
            }
            else if (option == "4")
            {                
                LoadGoal();
            }
            else if (option == "5")
            {                
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. CheckList Goal");  
        Console.WriteLine("  4. SelfReliance Goal");
    }

    public void ListGoalDetails()
    {
        int i = 0;
        string checkIt;
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {   
            if (goal.IsComplete())
            {
                checkIt = "X";
            }
            else
            {
                checkIt = " ";
            }
            Console.WriteLine($"{++i}. [{checkIt}] {goal.GetDetailsString()}");            
        }

        Console.Write("Press enter to continue... ");
        string dummy = Console.ReadLine();

    }

    public void CreateGoal()
    {
        string shortName;
        string description;
        string isComplete = "false";
        int points; 
        int target;
        int bonus;
        int duration;
        int amountCompleted = 0;
        int index = 0;
        string goalOption; 
        Goal newGoal;

        Console.Write("Which type of goal will you like to create? ");
        goalOption = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points for the goal? ");
        points = int.Parse(Console.ReadLine());

        if (goalOption == "1")
        {
            newGoal = new SimpleGoal(shortName, description, points, isComplete);
            _goals.Add(newGoal);
        }
        else if (goalOption == "2")
        {
            newGoal = new EternalGoal(shortName, description, points);
            _goals.Add(newGoal);
        }
        else if (goalOption == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
            newGoal = new CheckListGoal(shortName, description, points, bonus, target, amountCompleted);
            _goals.Add(newGoal);
        } 
        else if (goalOption == "4")
        {
            Console.Write("How long in (months) can you accomplish this goal? ");
            duration = int.Parse(Console.ReadLine());
            newGoal = new SelfRelianceGoal(shortName, description, points,duration,index);
            _goals.Add(newGoal);
        }       
    }

    public void RecordEvent()
    {
        int i = 0;
        int option;
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {            
            Console.WriteLine($"{++i}. {goal.GetShortName()}");            
        }
        Console.Write("Which goal did you accomplish? ");
        option = int.Parse(Console.ReadLine());
        _goals[option-1].RecordEvent();
        _score = _score + _goals[option-1].GetPoints();

        Console.WriteLine($"Congratulations!!! You have earned {_goals[option-1].GetPoints()} points.");
        Console.Write("Press enter to continue... ");
        string dummy = Console.ReadLine();
    }

    public void SaveGoal()
    {
        string file;
        Console.Write("Enter filename to save the goals: ");
        file = Console.ReadLine();

        using (var writer = new StreamWriter(file))
        {
            writer.WriteLine($"{_score}");

            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetStringPresentation()}");
            }

            Console.Write("Goals saved. Press enter to continue... ");
            string dummy = Console.ReadLine();
        }
    }

    public void LoadGoal()
    {
        string file;
        Console.Write("Enter filename of the goals to load from: ");
        file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        int score = int.Parse(lines[0]);

        string isComplete = "false";
        string goalName;
        string shortName;
        string description;
        int points;
        int bonus = 0;
        int target = 0;
        int amountCompleted = 0;
        int duration = 0;
        int index = 0;

        SimpleGoal simpleGoal;
        EternalGoal eternalGoal;
        CheckListGoal checkListGoal;
        SelfRelianceGoal selfRelianceGoal;
        _goals.Clear();
        _score = score;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(':');
            
            goalName = values[0];
            shortName = values[1];
            description = values[2];
            points = int.Parse(values[3]);
            
            if (values.Length == 5)
            {
                isComplete = values[4];                
            }
            else if (values.Length == 6)
            {
                duration = int.Parse(values[4]); 
                index = int.Parse(values[5]);              
            }
            else if (values.Length == 7)
            {
                bonus = int.Parse(values[4]);
                target = int.Parse(values[5]);
                amountCompleted = int.Parse(values[6]);
            }
                                                            
            if (goalName.Equals("SimpleGoal"))
            {
                simpleGoal = new SimpleGoal(shortName,description,points,isComplete);
                _goals.Add(simpleGoal);
            }
            else if (goalName.Equals("EternalGoal"))        
            {
                eternalGoal = new EternalGoal(shortName,description,points);
                 _goals.Add(eternalGoal);
            }
            else if (goalName.Equals("CheckListGoal"))
            {
                checkListGoal = new CheckListGoal(shortName,description,points,bonus,target,amountCompleted);
                 _goals.Add(checkListGoal);
            }
            else if (goalName.Equals("SelfRelianceGoal"))
            {
                selfRelianceGoal = new SelfRelianceGoal(shortName,description,points,duration,index);
                 _goals.Add(selfRelianceGoal);
            }
        }

        Console.Write("Goals loaded. Press enter to continue... ");
        string dummy = Console.ReadLine();

    }

}