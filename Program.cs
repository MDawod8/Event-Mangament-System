// Main program
public class Program
{
    public static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();

        Console.WriteLine("Welcome to the Event Management System!");

        while (true)
        {
            Console.WriteLine("Please enter a command:");
    string command = Console.ReadLine();

    switch (command)
    {
        case "create":
            eventManager.CreateEvent();
            break;
        case "list":
            eventManager.ListEvents();
            break;
        case "exit": 
            Console.WriteLine("Exiting the Event Management System. Goodbye!");
            Environment.Exit(0);
            break;
        default:
            if (command.StartsWith("get"))
            {
                if (command.Split(' ').Length > 1) 
                {
                    int id = int.Parse(command.Split(' ')[1]);
                    eventManager.GetEvent(id);
                }
                else
                {
                    Console.WriteLine("Please specify the ID of the event to get.");
                }
            }
            else if (command.StartsWith("update"))
            {
                if (command.Split(' ').Length > 1) 
                {
                    int id = int.Parse(command.Split(' ')[1]);
                    eventManager.UpdateEvent(id);
                }
                else
                {
                    Console.WriteLine("Please specify the ID of the event to update.");
                }
            }
            else if (command.StartsWith("delete"))
            {
                if (command.Split(' ').Length > 1) 
                {
                    int id = int.Parse(command.Split(' ')[1]);
                    eventManager.DeleteEvent(id);
                }
                else
                {
                    Console.WriteLine("Please specify the ID of the event to delete.");
                }
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
            break;
            }
        }
    }
}