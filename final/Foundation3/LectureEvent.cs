public class LectureEvent : Event
{
    private string _speaker;
    private string _capacity;

    public LectureEvent(string speaker,string capacity,string title, string description, Address address, string date, string time) : base(title,description,address,date,time)    
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureMessage()
    {
        StandardMessage();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    
}