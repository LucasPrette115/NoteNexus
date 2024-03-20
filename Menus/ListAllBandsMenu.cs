

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class ListAllBandsMenu : Menu
{

    public override void Execute(Dictionary<string, Band> registeredBands)
    {

        base.Execute(registeredBands);
        DisplayTitle("List of All Bands");
        foreach (var kvp in registeredBands)
        {
            Console.WriteLine($"Band: {kvp.Key}");
        }
        Console.WriteLine("\nType any key to continue...");
        Console.ReadKey();
        Console.Clear();
        
    }
}
