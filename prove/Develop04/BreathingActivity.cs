public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name,description)
    {
        
    }

    public void Run()
    {
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breath In... ");
            ShowCountDown(2);
            Console.WriteLine(" ");
            Console.WriteLine("Now Breath Out... ");
            ShowCountDown(2);
        }
                
        DisplayEndingMessage();
        Logger();
    
    }

}