

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class ListAllAlbumsMenu : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        DisplayTitle("Displaying every album from a band");
        Console.Write("Type in the name of the band: ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            if (registeredBands[bandName].Albums.Count != 0)
            {
                registeredBands[bandName].DisplayAlbums();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("There are no registered albums to this band!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }
        else
        {
            Console.WriteLine($"{bandName} not found!");
            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
        }

    }


}
