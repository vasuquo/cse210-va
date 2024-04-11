public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string rsvpEmail,string title, string description, Address address, string date, string time) : base(title,description,address,date,time)
    {
        _rsvpEmail = rsvpEmail;

    }

    public void ReceptionMessage()
    {
        StandardMessage();
        Console.WriteLine($"Email: {_rsvpEmail}");
    }

}