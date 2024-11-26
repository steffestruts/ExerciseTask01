using System.Collections.Generic;

/* "50/50" på Chatgpt-kod */

List<string> HungryList = new List<string>()!;

// Enkel konsolutskrivning
Console.WriteLine("Välkommen till Hungrig3000, din hungriga/shopping -lista! \n");
Console.WriteLine("Skriv in produkter du vill lägga till som gör mig eller dig hungrig.\nDu kan skriva mätt eller klar om du vill avsluta och se listan.\n");

// Loopar igenom tills avslutningsord är skrivet
while (true)
{
    // Uppmanar användaren att skriva produkter till listan
    Console.Write("Skriv in varor som kurrar i magen: ");
    string HungryItem = Console.ReadLine()!;

    // Skriver användaren "mätt" eller "klar" visas färdiga listan och sen avslutas inmatningen
    if (HungryItem.ToLower() == "mätt" || HungryItem.ToLower() == "klar") 
    {
        break;
    }
    else
    {
        // Lägger till i listan
        HungryList.Add(HungryItem);
        Console.WriteLine($"{HungryItem} är tillagd! \n");
    }
}

// Skriver ut listan efter användaren har skrivit avslutningsord
Console.Clear();
Console.WriteLine("Din lista är nu skapad! Tack för du använder Hungrig3000! Nu blev jag hungrig. (^o^)\n");
foreach (var Hungry in HungryList)
{
    Console.WriteLine("- " + Hungry);
}

Console.ReadKey();