public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, Address address, string date, string time)
    {
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
    }
    
    public void StandardMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}");
        Console.WriteLine($"Date: {_date}\nTime: {_time}");
        Console.WriteLine($"Address:\n{_address.GetAddress()} ");
    }

    public string GetShortDescription(string eventType)
    {
        string shortDescription = $"{eventType} - {_title} - {_date}";
        return shortDescription;
    }


}