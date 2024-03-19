

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class ListAllBandsMenu : Menu
{

    public void Execute(Dictionary<string, Band> registeredBands)
    {

        Console.Clear();
        DisplayTitle("List of All Bands");
        foreach (var kvp in registeredBands)
        {
            Console.WriteLine($"Band: {kvp.Key}");
        }
        Console.WriteLine("Type any key to continue...");
        Console.ReadKey();
        Console.Clear();
        
    }
}
