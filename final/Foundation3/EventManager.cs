public class EventManager
{
    Address address;
    string title;
    string date;
    string time;
    string description;
    string email;
    string weatherForecast;
    public void Start()
    {
        string option = "0";
        while (option != "4") 
        {
            Console.Clear();            
            Console.WriteLine(" ");
            Console.WriteLine("Event Menu:");
            Console.WriteLine("  1. Lecture Event");
            Console.WriteLine("  2. Reception Event");
            Console.WriteLine("  3. Outdoor Event");              
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {                                                                            
                CreateLectureEvent();                
            }
            else if (option == "2")
            {
                CreateReceptionEvent();

            }
            else if (option == "3")
            {
                CreateOutdoorEvent();

            }

        }
    }

    public void GetAddress()
    {
        Console.WriteLine("Enter address of venue as follows: ");
        Console.Write("Enter street: ");
        string street = Console.ReadLine();
        Console.Write("Enter city: ");
        string city = Console.ReadLine();
        Console.Write("Enter state: ");
        string state = Console.ReadLine();
        Console.Write("Enter country: ");
        string country = Console.ReadLine();

         address = new Address(street, city, state, country);

    }

    public void GetEventDetails()
    {
        Console.Write("Enter event title: ");
        title = Console.ReadLine();
        Console.Write("Enter date of event: ");
        date = Console.ReadLine();
        Console.Write("Enter time of event: ");
        time = Console.ReadLine();
        Console.WriteLine("Enter event description");
        description = Console.ReadLine();

    }

    public void CreateLectureEvent()
    {
        Console.Clear();
        GetEventDetails();
        GetAddress();
        Console.Write("Enter Name of speaker: ");
        string speaker = Console.ReadLine();
        Console.Write("Enter Hall capacity: ");
        string capacity = Console.ReadLine();
        
        LectureEvent lectureEvent = new LectureEvent(speaker,capacity,title,description,address,date,time);
        Console.Clear();
        Console.WriteLine("Standard Message:");
        lectureEvent.StandardMessage();
        Console.WriteLine("Full Details:");
        lectureEvent.LectureMessage();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.GetShortDescription("Lecture"));
        Console.Write("Press enter to continue... ");
        string dummy = Console.ReadLine();

    }

    public void CreateReceptionEvent()
    {
        Console.Clear();
        GetEventDetails();
        GetAddress();
        Console.Write("Enter email address for RSVP: ");
        email = Console.ReadLine();

        ReceptionEvent receptionEvent = new ReceptionEvent(email,title,description,address,date,time);
        Console.Clear();
        Console.WriteLine("Standard Message:");
        receptionEvent.StandardMessage();
        Console.WriteLine("Full Details:");
        receptionEvent.ReceptionMessage();
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent.GetShortDescription("Reception"));
        Console.Write("Press enter to continue... ");
        string dummy = Console.ReadLine();

    }

    public void CreateOutdoorEvent()
    {
        Console.Clear();
        GetEventDetails();
        GetAddress();
        Console.Write("Enter weather forecast: ");
        weatherForecast = Console.ReadLine();

        OutdoorEvent outdoorEvent = new OutdoorEvent(weatherForecast,title,description,address,date,time);
        Console.Clear();
        Console.WriteLine("Standard Message:");
        outdoorEvent.StandardMessage();
        Console.WriteLine("Full Details:");
        outdoorEvent.OutdoorMessage();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription("Outdoor"));
        Console.Write("Press enter to continue... ");
        string dummy = Console.ReadLine();

    }

}