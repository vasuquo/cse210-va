using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity running = new RunningActivity(4.8f,"20-04-2024",30);
        SwimmingActivity swimming = new SwimmingActivity(30,"21-04-2024",15);
        CyclingActivity cycling = new CyclingActivity(4,"22-04-2024",25);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());            
        }

    }
}