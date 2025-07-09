using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        PartyBase party = null;

        // asking what kind of party it is
        Console.WriteLine("Select the party type:");
        Console.WriteLine("1. Birthday");
        Console.WriteLine("2. Wedding");
        Console.WriteLine("3. Club");
        string typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1": party = new BirthdayParty(); break;
            case "2": party = new WeddingParty(); break;
            case "3": party = new ClubParty(); break;
            default: Console.WriteLine("Invalid choice."); return;
        }

        // party name and location
        Console.Write("Enter the party name: ");
        party.Name = Console.ReadLine();

        Console.Write("Enter the location name: ");
        party.Location = Console.ReadLine();

        // indoor or outdoor selection
        Console.Write("Is the location indoor or outdoor? (indoor/outdoor): ");
        string locationType = Console.ReadLine().Trim().ToLower();

        // attendee count
        Console.Write("How many guests will attend? ");
        party.NumberOfGuests = int.Parse(Console.ReadLine());

        // food
        Console.Write("Will you serve food? (yes/no): ");
        bool hasFood = Console.ReadLine().Trim().ToLower() == "yes";
        double mealPrice = 0;
        if (hasFood)
        {
            Console.WriteLine("Select meal option: ");
            Console.WriteLine("1) 1 course meal ");
            Console.WriteLine("2) 2 course meal ");
            Console.WriteLine("3) 3 course meal ");
            int mealChoice = int.Parse(Console.ReadLine());
            mealPrice = mealChoice == 1 ? 30 : mealChoice == 2 ? 45 : 60;
        }

        // drinks
        Console.Write("Do you want drinks? (yes/no): ");
        bool hasDrinks = Console.ReadLine().Trim().ToLower() == "yes";
        bool hasAlcohol = false;
        double drinksPrice = 0;
        if (hasDrinks)
        {
            Console.Write("Include alcoholic drinks? (yes/no): ");
            hasAlcohol = Console.ReadLine().Trim().ToLower() == "yes";
            if (hasAlcohol)
            {
                Console.Write("Will you bring your own drinks? ");
                bool ownDrinks = Console.ReadLine().Trim().ToLower() == "yes";
                if (ownDrinks)
                {
                    drinksPrice = 8 + 3 ; // 1 alcoholic + 1 non-alcoholic per person
                }
                else
                {
                    drinksPrice = 20 + 8 ; // 1 alcoholic + 1 non-alcoholic per person
                }
            }

            else
                drinksPrice = 2 * 3 ; // 2 non-alcoholic per person
        }

        // snacks
        Console.Write("Will you serve snacks? (yes/no): ");
        double snacksPrice = 0;
        bool hasSnacks = Console.ReadLine().Trim().ToLower() == "yes";

        if (hasSnacks)
        {
            snacksPrice = hasSnacks ? 2 : 0;
        }

        //  other stuff
        if (party is BirthdayParty bp)
        {
            Console.Write("Who is the birthday person? ");
            bp.BirthdayPerson = Console.ReadLine();
        }
        else if (party is WeddingParty wp)
        {
            Console.Write("Bride's name: ");
            wp.Bride = Console.ReadLine();

            Console.Write("Groom's name: ");
            wp.Groom = Console.ReadLine();

            Console.Write("Will you rent a venue? (yes/no): ");
            wp.VenueRented = Console.ReadLine().Trim().ToLower() == "yes";   
            
            Console.Write("Will you hire a DJ or musician? (yes/no): ");
            wp.DJOrMusicianHired = Console.ReadLine().Trim().ToLower() == "yes";
        }
        else if (party is ClubParty cp)
        {
            Console.Write("Club name: ");
            cp.ClubName = Console.ReadLine();

            Console.Write("Will you hire a DJ? (yes/no): ");
            cp.DJHired = Console.ReadLine().Trim().ToLower() == "yes";
        }
        


      

        double totalFood = hasFood ? party.NumberOfGuests * mealPrice : 0;
        double totalDrinks = hasDrinks ? party.NumberOfGuests * drinksPrice : 0;
        double totalSnacks = hasSnacks ? party.NumberOfGuests * snacksPrice : 0;

        double totalCost = totalFood + totalDrinks + totalSnacks;

        // Print summary and cost
        Console.WriteLine("\n--- Party Summary ---");
        Console.WriteLine("Type: " + party.GetType().Name.Replace("Party", " Party"));
        Console.WriteLine("Name: " + party.Name);
        Console.WriteLine("Location: " + party.Location + " (" + locationType + ")");
        Console.WriteLine("Number of guests: " + party.NumberOfGuests);
        if (hasFood)
            Console.WriteLine("Foods: " + string.Join(", ", party.Foods));
        if (hasDrinks)
            Console.WriteLine("Drinks: " + string.Join(", ", party.Drinks) + (hasAlcohol ? " (alcohol included)" : " (non-alcoholic)"));
        if (hasSnacks)
            Console.WriteLine("Snacks: " + string.Join(", ", party.Snacks));

    
        party.PlanParty();

        Console.WriteLine("\n--- Cost Calculation ---");
        if (hasFood)
            Console.WriteLine($"Food: {mealPrice} per person x {party.NumberOfGuests} = {totalFood}");
        if (hasDrinks)
            Console.WriteLine($"Drinks: {drinksPrice} per person x {party.NumberOfGuests} = {totalDrinks}");
        if (hasSnacks)
            Console.WriteLine($"Snacks: {snacksPrice} per person x {party.NumberOfGuests} = {totalSnacks}");
        Console.WriteLine($"Total Cost: {totalCost}");

        Console.WriteLine("\n--- Party Planning Completed! ---");
    }
}
