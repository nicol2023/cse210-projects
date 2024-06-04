using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");
        Address address3 = new Address("789 Oak St", "Denver", "CO", "USA");

        // Create Events
        Event lecture = new Lecture("Tech Talk", "A lecture on the latest in technology.", "2024-06-10", "10:00 AM", address1, "Dr. Smith", 100);
        Event reception = new Reception("Wedding Reception", "A beautiful wedding reception.", "2024-06-20", "5:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Music Festival", "An outdoor music festival.", "2024-07-15", "12:00 PM", address3, "Sunny with a chance of rain");

        // List of events
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}