using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Oak St", "Somewhere", "TX", "10112");

        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", new DateTime(2024, 8, 1), "10:00 AM", address1, "Jane Doe", 100);
        Event reception = new Reception("Company Gala", "An annual gathering of the company", new DateTime(2024, 9, 1), "7:00 PM", address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun day at the park", new DateTime(2024, 7, 31), "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:\n" + ev.GetStandardDetails() + "\n");
            Console.WriteLine("Full Details:\n" + ev.GetFullDetails() + "\n");
            Console.WriteLine("Short Description:\n" + ev.GetShortDescription() + "\n");
        }
    }
}
