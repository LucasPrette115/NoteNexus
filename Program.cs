


using NoteNexus.Models;
class Program
{
    static void Main(string[] args)
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
            Console.WriteLine("\nWelcome to NoteNexus!");
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
                        case 1: RegisterBand();
                            break;
                        case 2: ListAllBands();
                            break;
                        case 3: RateBand();
                            break;
                        case 4: AverageRating();
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
          void RegisterBand()
        {
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("***/ Register a band /***");
                    Console.Write("What band do you want to register: ");
                    string bandName = Console.ReadLine()!;
                    Console.Write($"Is this the band you would like to register ({bandName}) ? (y/n) : ");
                    string input = Console.ReadLine()!;
                    if (input.ToLower() != "y" && input.ToLower() != "n")
                        throw new ArgumentException();
                    else if (input.ToLower() == "n")
                        RegisterBand();
                    else if ( input.ToLower() == "y")
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
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    DisplayMenu();
                }


            } while (true);
            Thread.Sleep(2000);
            Console.Clear();
            DisplayMenu();
        }

        void ListAllBands()
        {
            Console.Clear();
            Console.WriteLine("***/ Listing every band /***");
            foreach (var kvp in registeredBands)
            {
                Console.WriteLine($"Band: {kvp.Key}");
            }
            Console.WriteLine("Type any key to continue...");
            Console.ReadKey();
            Console.Clear();
            DisplayMenu();
        }
        void RateBand()
        {
            Console.Clear();
            Console.WriteLine("***/ Rate a band /***");
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
                        int rating = Convert.ToInt32(Console.ReadLine());
                        if (rating < 0 || rating > 10) { throw new ArgumentOutOfRangeException(); }
                        band.AddRating(rating);
                        Console.WriteLine($"Band {band.Name} rated sucessfully");
                        break;
                        
                    }
                    catch(ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Out of range input -> {ex.Message}");
                    }
                    catch(Exception ex)
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
                DisplayMenu();
            }
            Thread.Sleep(2000);
            Console.Clear();
            DisplayMenu();
        }

        void AverageRating()
        {
            Console.Clear();
            Console.WriteLine("*****/ Average rating of all bands /*****");
            
            foreach (var key in registeredBands)
            {
                double sum = 0;
                for (int i = 0; i < key.Value.Ratings.Count; i++)
                {
                    sum += key.Value.Ratings[i];
                }
                Console.WriteLine($"\nAverage rating for {key.Value.Name} : {sum/ key.Value.Ratings.Count}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            DisplayMenu();
        }

        DisplayMenu();



    }

    
}
   