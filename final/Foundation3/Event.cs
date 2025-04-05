public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress:\n{address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails(); // overridden in child classes
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {title}\nDate: {date}";
    }
}