using NoteNexus.Models;

namespace NoteNexus.Menus;
internal class AverageRatingMenu : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)   
    {
        base.Execute(registeredBands);
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
