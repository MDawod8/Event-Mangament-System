using System;
using System.Collections.Generic;

// EventManager class
public class EventManager
{
    private List<Event> events = new List<Event>();
    private int nextEventId = 1;

    // Create new event
    public void CreateEvent()
    {
        Console.WriteLine("Enter Event Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Description (optional):");
        string description = Console.ReadLine();

        Console.WriteLine("Enter Date (yyyy-MM-dd):");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date)){
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format:");
        }

        Console.WriteLine("Enter Location (optional):");
        string location = Console.ReadLine();

        Event newEvent = new Event();
        newEvent.SetId(nextEventId++);
        newEvent.SetName(name);
        newEvent.SetDescription(description);
        newEvent.SetDate(date);
        newEvent.SetLocation(location);

        events.Add(newEvent);
        Console.WriteLine("Event created successfully!");
    }

    // List all events
    public void ListEvents()
    {
        if (events.Count == 0)
        {
            Console.WriteLine("No events found.");
            return;
        }

        foreach (Event e in events)
        {
            Console.WriteLine($"ID: {e.GetId()}, Name: {e.GetName()}, Date: {e.GetDate().ToString("yyyy-MM-dd")}, Location: {e.GetLocation()}");
        }
    }

    // Get event with ID
    public void GetEvent(int id)
    {
        Event e = events.Find(x => x.GetId() == id); 
        if (e == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        Console.WriteLine("Event Details:");
        Console.WriteLine($"Name: {e.GetName()}"); 
        Console.WriteLine($"Description: {e.GetDescription()}"); 
        Console.WriteLine($"Date: {e.GetDate().ToString("yyyy-MM-dd")}"); 
        Console.WriteLine($"Location: {e.GetLocation()}"); 
    }

    // Update event with ID
    public void UpdateEvent(int id)
    {
        Event e = events.Find(x => x.GetId() == id); 
        if (e == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        Console.WriteLine("Enter new Event Name (leave empty to keep current):");
        string name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
        {
            e.SetName(name); 
        }

        Console.WriteLine("Enter new Description (leave empty to keep current):");
        string description = Console.ReadLine();
        if (!string.IsNullOrEmpty(description))
        {
            e.SetDescription(description); 
        }

        Console.WriteLine("Enter new Date (leave empty to keep current):");
        string dateString = Console.ReadLine();
        if (!string.IsNullOrEmpty(dateString))
        {
            DateTime newDate;
            while (!DateTime.TryParse(dateString, out newDate)){
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format:");
            dateString = Console.ReadLine(); 
            
            } 
            e.SetDate(newDate);
        }

        

        Console.WriteLine("Enter new Location (leave empty to keep current):");
        string location = Console.ReadLine();
        if (!string.IsNullOrEmpty(location))
        {
            e.SetLocation(location); 
        }

        Console.WriteLine("Event updated successfully!");
    }

    // Delete an event
    public void DeleteEvent(int id)
    {
        Event e = events.Find(x => x.GetId() == id); 
        if (e == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        events.Remove(e);
        Console.WriteLine("Event deleted successfully!");
    }
}

