

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class RegisterAlbumMenu : Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayTitle("Register a Album to a Band");
        Console.Write("Which band do you wanna register an album to?: ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName)) 
        {
            do
            {
                try
                {
                    
                    Console.Write("What's the name of the album?: ");
                    string albumName = Console.ReadLine()!;
                    Album album = new Album(albumName, new List<Music>());
                    registeredBands[bandName].AddAlbum(album);
                    Console.WriteLine($"{album.Name} registered sucessfully to {registeredBands[bandName].Name}!");
                    Thread.Sleep(2000);
                    Console.Clear();

                    break;

                }
                catch(Exception e) 
                {
                    Console.WriteLine($"{e.Message}");

                }

            } while (true);
        }
        else
        {
            Console.WriteLine($"{bandName} not found!");
            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
        }





    }

}
