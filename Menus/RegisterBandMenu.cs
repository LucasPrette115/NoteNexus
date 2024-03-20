


using NoteNexus.Interfaces;
using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class RegisterBandMenu : Menu
{
      public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        do
        {
            try
            {
                
                DisplayTitle("Register a Band");
                Console.Write("What band do you want to register: ");
                string bandName = Console.ReadLine()!;
                Console.Write($"Is this the band you would like to register ({bandName}) ? (y/n) : ");
                string input = Console.ReadLine()!;
                if (input.ToLower() != "y" && input.ToLower() != "n")
                    throw new ArgumentException();
                else if (input.ToLower() == "n")
                    Execute(registeredBands);
                else if (input.ToLower() == "y")
                {
                    Band band = new Band(bandName, new List<Album>());
                    registeredBands.Add(band.Name, band);
                    Console.WriteLine($"{band.Name} registered sucessfully!");

                }

                break;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid input | Expected y or n : {e.Message}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
               
            }


        } while (true);
        Thread.Sleep(2000);
        Console.Clear();
        
    }

}
