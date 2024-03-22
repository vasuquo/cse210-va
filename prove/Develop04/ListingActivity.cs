public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.Write("You may begin in: ");        
        string dummy = Console.ReadLine();
        
        Console.WriteLine(" ");
        ShowCountDown(0);
        string response;

        while(DateTime.Now < endTime)
        {            
            Console.Write("> ");
            response = Console.ReadLine();
            userList.Add(response);            
        }

        return userList;
    }

    public void Run()
    {
        
        Console.WriteLine("List as many responses you can to this following prompt");
        Console.WriteLine(" ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine(" ");
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        
                
        DisplayEndingMessage();
        Logger();

    }


}