using System;

public class ClubParty : PartyBase
{
    public bool DJHired { get; set; }
    public string ClubName { get; set; }

    public override void PlanParty()
    {
        Console.WriteLine("Club Party Plan:");
        Console.WriteLine("- Reserve club: " + ClubName);
        Console.WriteLine("- Hire DJ: " + (DJHired ? "Yes" : "No"));
        Console.WriteLine("- Create guest list");
        Console.WriteLine("- Prepare drinks and snacks");
        Console.WriteLine("- Arrange light and sound");
    }
}
