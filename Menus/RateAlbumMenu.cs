

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class RateAlbumMenu : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        
        do
        {
            try
            {
                base.Execute(registeredBands);
                DisplayTitle("Add music to an album");
                Console.Write("For which band is it?: ");
                string bandName = Console.ReadLine()!;
                if (registeredBands.ContainsKey(bandName))
                {
                    Console.Write("Which album do you wanna rate?: ");
                    string albumName = Console.ReadLine()!;
                    bool albumFound = false;                  
                    
                        if (registeredBands[bandName].Albums.Any(a => a.Name.Equals(albumName)))
                        {
                            albumFound = true;
                            Album album = registeredBands[bandName].Albums.First(a => a.Name.Equals(albumName));
                            Console.Write("Rate this album out of 10: ");
                            Ratings rating = Ratings.Parse(Console.ReadLine()!);
                            album.AddRating(rating);
                            Console.WriteLine($"{rating.Rating} registered successfully to {albumName}");
                            Thread.Sleep(2000);

                        }
                                           
                    if (!albumFound)
                    {
                        Console.WriteLine($"{albumName} not found in {bandName}!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine($"{bandName} not found!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                break;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        } while (true);
       

    }
}
