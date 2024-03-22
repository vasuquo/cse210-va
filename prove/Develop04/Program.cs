using System;

class Program
{
    //Saving log of activities in a file "log.txt"
    //loading and viewing content of log file"
    //Ensure random questions are unique.
    static void Main(string[] args)
    {
        string description;
        string option = "0";
        while (option != "5") 
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");  
            Console.WriteLine("  4. View log");   
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {                             
                description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";                                
                BreathingActivity breathingActivity = new BreathingActivity("Breathing",description);
                breathingActivity.Run();
            }
            else if (option == "2")
            {
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", description);
                reflectingActivity.Run();
            }
            else if (option == "3")
            {
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingActivity = new ListingActivity("Listing", description);
                listingActivity.Run();
            }
            else if (option == "4")
            {
                Activity activity = new Activity();
                activity.ViewLog();

            }
        }
    }
}