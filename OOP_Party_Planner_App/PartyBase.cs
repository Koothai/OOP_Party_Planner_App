public abstract class PartyBase
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public int NumberOfGuests { get; set; }
    public List<string> Drinks { get; set; } = new List<string>();
    public List<string> Foods { get; set; } = new List<string>();
    public List<string> Snacks { get; set; } = new List<string>();

    public abstract void PlanParty();
}
