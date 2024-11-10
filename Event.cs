// Event class
public class Event
{
    private int Id { get; set; }
    private string Name { get; set; }
    private string Description { get; set; }
    private DateTime Date { get; set; }
    private string Location { get; set; }

    //Getters and Setters
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }
    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }
    public string GetDescription() { return Description; }
    public void SetDescription(string description) { Description = description; }
    public DateTime GetDate() { return Date; }
    public void SetDate(DateTime date) { Date = date; }
    public string GetLocation() { return Location; }
    public void SetLocation(string location) { Location = location;}
}