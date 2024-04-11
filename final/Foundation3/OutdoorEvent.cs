public class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent(string weatherForecast,string title, string description, Address address, string date, string time) : base(title,description,address,date,time)
    {
        _weatherForecast = weatherForecast;

    }

    public void OutdoorMessage()
    {
        StandardMessage();
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }

    
}