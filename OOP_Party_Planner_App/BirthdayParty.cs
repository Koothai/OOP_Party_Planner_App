using System;

public class BirthdayParty : PartyBase
{
    public string BirthdayPerson { get; set; }

    public override void PlanParty()
    {
        Console.WriteLine("Birthday Party Plan:");
        Console.WriteLine("- Buy a cake for " + BirthdayPerson);
        Console.WriteLine("- Send invitations");
        Console.WriteLine("- Decorate the venue");
        Console.WriteLine("- Prepare foods and snacks");
        Console.WriteLine("- Play birthday games");
    }
}
