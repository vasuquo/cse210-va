using System;

class Program
{
        //In exceeding requirement the journal is saved as csv file "journal.csv"
        //and loading is also from the csv file. 
    static void Main(string[] args)
    {
        Journal journal = new Journal();        
        string option = "0";
        string file = "";
        while (option != "5") 
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Write a journal");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save journal");    
            Console.WriteLine("5. Quit");

            Console.Write("What will you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {                                        
                PromptGenerator promptGenerator = new PromptGenerator();              
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                Console.Write("> ");
                string entryText = Console.ReadLine(); 
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToString();
                Entry entry = new Entry(date, promptText, entryText);
                journal.AddEntry(entry);
            }
            else if (option == "2")
            {              
              journal.DisplayAll(); 
            }
            else if (option == "3")
            {
                Console.Write("Enter filename to load: ");
                file = Console.ReadLine();
                journal._entries.Clear();
                journal.LoadFromFile(file);
            }
            else if (option == "4")
            {
                Console.Write("Enter filename to save journal: ");
                file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            
        }
        
        
        
         
             
    }
}