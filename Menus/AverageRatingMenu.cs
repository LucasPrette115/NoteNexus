using NoteNexus.Models;

namespace NoteNexus.Menus;
internal class AverageRatingMenu : Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)   
    {
        Console.Clear();
        DisplayTitle("Average rating for every Band");

        foreach (var key in registeredBands)
        {
            Console.WriteLine($"{key.Value.Name} : {key.Value.AverageRating}");
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
       


    }
}
