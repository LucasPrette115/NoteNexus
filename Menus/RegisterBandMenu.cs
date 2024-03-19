using NoteNexus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Menus;

internal class RegisterBandMenu : Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        do
        {
            try
            {
                Console.Clear();
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
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
               
            }


        } while (true);
        Thread.Sleep(2000);
        Console.Clear();
        
    }

}
