using System;

public class WeddingParty : PartyBase
{
    public string Bride { get; set; }
    public string Groom { get; set; }
    public bool VenueRented { get; set; }
    public bool DJOrMusicianHired { get; set; }

    public override void PlanParty()
    {
        Console.WriteLine("Wedding Party Plan:");
        Console.WriteLine("- Choose a venue" + (VenueRented ? " (Venue rented!)" : ""));
        Console.WriteLine("- Send wedding invitations");
        Console.WriteLine("- Arrange catering");
        Console.WriteLine("- Prepare foods and snacks");
        Console.WriteLine("- Hire DJ or musician: " + (DJOrMusicianHired ? "Yes" : "No"));
        Console.WriteLine("- Flower arrangements");
        Console.WriteLine("- Ceremony for " + Bride + " and " + Groom);
    }
}
