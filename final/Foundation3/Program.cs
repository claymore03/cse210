using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Ocean Dr", "Miami", "FL", "USA");
        Address addr3 = new Address("789 Pine Rd", "Denver", "CO", "USA");

        Event lecture = new Lecture("Tech Talk", "Latest in AI", "2025-05-01", "10:00 AM", addr1, "Dr. Smith", 100);
        Event reception = new Reception("Networking Night", "Meet professionals", "2025-06-15", "6:00 PM", addr2, "rsvp@event.com");
        Event outdoor = new OutdoorGathering("Summer Fest", "Music and Food", "2025-07-20", "3:00 PM", addr3, "Sunny with clouds");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (var evt in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n===============================\n");
        }
    }
}