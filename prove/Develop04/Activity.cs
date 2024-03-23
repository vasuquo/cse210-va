public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        DisplayStartingMessage();
        Console.Write("How long in seconds will you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine("Get Ready... ");
        Console.WriteLine(" ");
        ShowSpinner(2);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();  
        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well Done!!!");
        ShowSpinner(4);
        Console.WriteLine(" ");
        Console.WriteLine($"Your have completed another {_duration} seconds of {_name} Activity");
        ShowSpinner(6);
    }

    public void ShowSpinner(int seconds)
    {
        String[] spinner = new String[5] {"|", "/", "-", "|", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int looper = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[looper]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            looper++;
            if (looper >= spinner.Length)
            {
                looper = 0;
            }            
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"...{i}");
            Thread.Sleep(1000*seconds);
            Console.Write("\b\b\b\b    \b\b\b\b");
        }
    }

    public void Logger()
    {
        string path = @"log.txt";
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToString();
        StreamWriter sw;

        if (!File.Exists(path))
        {
            sw = File.CreateText(path);
            
        }
        else
        {
            sw = File.AppendText(path);
        }

        using (sw)
        {
            sw.WriteLine($"{date},{_name} Activity,{_duration}");
        }
    }

    public void ViewLog()
    {
        
        string path = "log.txt";
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            Console.Clear();
            Console.WriteLine("Log Time                 Activity Name       Duration(Seconds)");

            foreach (string line in lines)
            {            
                string[] values = line.Split(',');
                string date;
                string name;
                string duration;
                            
                date = values[0];
                name = values[1];
                duration = values[2];

                Console.WriteLine($"{date}    {name}     {duration}");
                                
            }

        }

        Console.Write("Press Enter to continue.. ");        
        string dummy = Console.ReadLine();
        
                        
        
        
                                                                                            
    }
}