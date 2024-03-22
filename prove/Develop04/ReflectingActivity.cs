public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name,description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");        

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");                
        

    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(" ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine(" ");
        Console.Write("When you have sometime in mind press enter to continue... ");
        string dummy = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");        
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        ShowCountDown(duration);        
    }

    public void DisplayQuestion()
    {
        List<string> usedQuestions = new List<string>();
        string question;                           

        while (true)
        {
            if (_questions.Count == usedQuestions.Count)
            {
                break;
            }
            
            question = GetRandomQuestion();

            if (!usedQuestions.Contains(question))  
            {                
                usedQuestions.Add(question);
                Console.WriteLine($"> {question}");
                ShowSpinner(3);
            }
                                                                                                                                     
        }
                
    }

    public void Run()
    {
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while(DateTime.Now < endTime)
        {
            DisplayPrompt();
            DisplayQuestion();
        }
                
        DisplayEndingMessage();
        Logger();

    }
}