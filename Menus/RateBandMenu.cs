
using NoteNexus.Models;
namespace NoteNexus.Menus;


internal class RateBandMenu : Menu
{
    
    public override void Execute(Dictionary<string, Band> registeredBands)
    {

        base.Execute(registeredBands);
        DisplayTitle("Rate a Band");
        Console.Write("Which band would you like to rate?: ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            do
            {
                try
                {
                    Band band = registeredBands[bandName];

                    Console.Write("Rate this band out of 10: ");
                    Ratings rating = Ratings.Parse(Console.ReadLine()!);
                    band.AddRating(rating);
                    Console.WriteLine($"Band {band.Name} rated sucessfully!");
                    break;

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Out of range input -> {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}");
                }
            } while (true);


        }
        else
        {
            Console.WriteLine($"{bandName} not found!");
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            
        }
        Thread.Sleep(2000);
        Console.Clear();
        
    }
}
