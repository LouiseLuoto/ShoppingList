using System;

internal class Program
{
    private static void Main(string[] args)
    {   /*Mål: Skapa ett program där användaren kan skapa och hantera en shoppinglista med hjälp av
        en List<string>. Använd inte klasser i denna uppgift (förutom class Program)
        Steg 1: Skapa en tom lista som representerar shoppinglistan.
        Steg 2: Implementera en meny med följande alternativ:
        1. Lägga till en artikel: Låter användaren skriva in namnet på en artikel att lägga till i
        listan.
        2. Ta bort en artikel: Låter användaren skriva in namnet på en artikel att ta bort från
        listan.
        3. Visa hela listan: Visar alla artiklar i listan.
        4. Sök efter en artikel: Låter användaren skriva in ett namn och meddelar om artikeln
        finns i listan eller inte.
        5. Avsluta programmet: Avslutar programmet.**/
       List<string> shoppinglist = new List<string>();
       
    bool isRunning = true;
    while (isRunning)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Välkommen till shoppinglistan!");
        Console.WriteLine("1. Lägg till en artikel.");
        Console.WriteLine("2. Ta bort en artikel.");
        Console.WriteLine("3. Visa hela listan.");
        Console.WriteLine("4. Sök efter en artikel.");
        Console.WriteLine("5 Avsluta programmet.");
        Console.Write("Val: ");
        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Vilken artikel vill du lägga till?: ");
                shoppinglist.Add(Console.ReadLine());
                Console.WriteLine("Artikel tillagd!");
                break;
            case "2":
                Console.Write("Vilken artikel vill du ta bort?: ");
                for (int i = 0; i < shoppinglist.Count; i++)
                shoppinglist.RemoveAt(i);
                Console.WriteLine("Artikel borttagen!");
                break;
            case "3":
                for (int i = 0; i < shoppinglist.Count; i++)
                Console.WriteLine(shoppinglist[i]);
                break;
            case "4":
                    Console.Write("Vilken artikel vill du söka efter?: ");
                    string? item = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < shoppinglist.Count; i++)
                    {
                        if (shoppinglist[i] == item)
                        {
                            Console.WriteLine("Varan finns i listan");
                            break;
                        }
                        else if (!found)
                        {
                            Console.WriteLine("Varan finns inte i listan");
                            break;
                        }
                    }
                    break;
            case "5":
                Console.WriteLine("Avslutar...");
                isRunning = false;
                break;
            default:
                Console.WriteLine("Vad menar du nu? Testa igen.");
                break;
        }
        Console.ReadKey();
        }
   }
}