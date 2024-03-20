


using NoteNexus.Models;
using NoteNexus.Menus;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Band> registeredBands = new();
        Dictionary<int, Menu> options = new();
        options.Add(1, new RegisterBandMenu());
        options.Add(2, new ListAllBandsMenu());
        options.Add(3, new RateBandMenu());
        options.Add(4, new AverageRatingMenu());
        options.Add(5, new RegisterAlbumMenu());
        options.Add(6, new ListAllAlbumsMenu());
        options.Add(7, new AddMusicToAlbumMenu());     
        
        void DisplayLogo()
        {
                        Console.WriteLine(@"
            ███╗░░██╗░█████╗░████████╗███████╗███╗░░██╗███████╗██╗░░██╗██╗░░░██╗░██████╗
            ████╗░██║██╔══██╗╚══██╔══╝██╔════╝████╗░██║██╔════╝╚██╗██╔╝██║░░░██║██╔════╝
            ██╔██╗██║██║░░██║░░░██║░░░█████╗░░██╔██╗██║█████╗░░░╚███╔╝░██║░░░██║╚█████╗░
            ██║╚████║██║░░██║░░░██║░░░██╔══╝░░██║╚████║██╔══╝░░░██╔██╗░██║░░░██║░╚═══██╗
            ██║░╚███║╚█████╔╝░░░██║░░░███████╗██║░╚███║███████╗██╔╝╚██╗╚██████╔╝██████╔╝
            ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝░╚═════╝░╚═════╝░");
                        Console.WriteLine("\nWelcome to NoteNexus!\n");
        }

        void DisplayMenu()
        {
              Console.Clear();

            do
            {
                try
                {
                    DisplayLogo();
                    Console.WriteLine("Type 1 to register a band");
                    Console.WriteLine("Type 2 to list all bands");
                    Console.WriteLine("Type 3 to rate a band");
                    Console.WriteLine("Type 4 to display the average rating of the bands");
                    Console.WriteLine("Type 5 to register an album to a band");
                    Console.WriteLine("Type 6 to list every album from a band");
                    Console.WriteLine("Type 7 to add a music to an album");
                    Console.WriteLine("Type -1 to exit");
                    Console.Write("\nSelect an item: ");

                    int userInput = int.Parse(Console.ReadLine()!);
                    if (options.ContainsKey(userInput))
                    {
                        Menu menu = options[userInput];
                        menu.Execute(registeredBands);
                        if (userInput > 0) DisplayMenu();
                    }
                    else
                    {
                        if (userInput == -1) break;
                        throw new ArgumentOutOfRangeException();
                    }

                    break;

                }catch (ArgumentOutOfRangeException ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid input: {ex.Message}\n");

                }
            }while (true);
        }     
        DisplayMenu();



    }

    
}
   