using System.Collections.Generic;

/* 50/50 på Chatgpt-kod */

List<string> HungryList = new List<string>()!;

// Enkel konsolutskrivning
Console.WriteLine("Välkommen till din hungrig/shopping -lista! \n");
Console.WriteLine("Skriv in produkter du vill lägga till som gör dig hungrig.\nDu kan skriva mätt eller klar om du vill avsluta och se listan.\n");

// Loopar igenom tills avslutningsord är skrivet
while (true)
{
    // Uppmanar användaren att skriva produkter till listan
    Console.Write("Skriv in varor som kurrar i magen:");
    string HungryItem = Console.ReadLine()!;

    // Skriver användaren "mätt" eller "klar" visas färdiga listan och sen avslutas inmatningen
    if (HungryItem.ToLower() == "mätt" || HungryItem.ToLower() == "klar") 
    {
        Console.WriteLine("\n");
        break;
    }

    // Lägger till i listan
    HungryList.Add(HungryItem);
}

// Skriver ut listan efter användaren har skrivit avslutningsord
Console.WriteLine("Hungrig/Shopping -listan som du har skrivit:");
foreach (var Hungry in HungryList)
{
    Console.WriteLine("- " + Hungry);
}

Console.ReadKey();