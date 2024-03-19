


using NoteNexus.Models;
using NoteNexus.Menus;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Band> registeredBands = new();
        
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
                    Console.WriteLine("Type 2 to  list all bands");
                    Console.WriteLine("Type 3 to rate a band");
                    Console.WriteLine("Type 4 to display the average rating of the bands");
                    Console.WriteLine("Type -1 to exit");
                    Console.Write("Select an item: ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: RegisterBandMenu menu1 = new();
                            menu1.Execute(registeredBands);
                            DisplayMenu();
                            break;
                        case 2: ListAllBandsMenu menu2 = new();
                            menu2.Execute(registeredBands);
                            DisplayMenu();
                            break;
                        case 3: RateBandMenu menu3 = new RateBandMenu();
                            menu3.Execute(registeredBands);
                            DisplayMenu();
                            
                            break;
                        case 4: AverageRatingMenu menu4 = new();
                            menu4.Execute(registeredBands);
                            DisplayMenu();
                            break;
                    }
                    break;

                }catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid input: {ex.Message}\n");

                }
            }while (true);
        }     
        DisplayMenu();



    }

    
}
   