using System.Collections.Generic;

List<string> ShoppingList = new List<string>();

Console.WriteLine("Välkommen till din shopping/hungrig -lista!");
Console.WriteLine("Skriv in produkter du vill lägga till som gör dig hungrig. Du kan skriva mätt när du vill avsluta och se listan. \n");

while (true)
{
    Console.Write("Skriv in varor som kurrar i magen:");
    string shoppingItem = Console.ReadLine();

    // Om användaren skriver 'klar', avsluta inmatningen
    if (shoppingItem.ToLower() == "mätt" || shoppingItem.ToLower() == "klar")
    {
        Console.WriteLine("\n");
        break;
    }

    ShoppingList.Add(shoppingItem);
}


Console.WriteLine("Shopping/Hungrig -lista som du har skrivit:");
foreach (var Shopping in ShoppingList)
{
    Console.WriteLine("- " + Shopping);
}

Console.ReadKey();

/* 50/50 på Chatgpt-kod */