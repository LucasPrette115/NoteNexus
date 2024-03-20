

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class AddMusicToAlbumMenu : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        
        base.Execute(registeredBands);
        DisplayTitle("Add music to an album");        
        if (registeredBands.Count != 0)
        {
            Console.Write("Which album is it?: ");
            string userInput = Console.ReadLine()!;
            foreach (var kvp in registeredBands)
            {
                for (var i = 0; i < registeredBands[kvp.Key].Albums.Count; i++)
                {
                    if (registeredBands[kvp.Key].Albums[i].Name == userInput)
                    {
                        do
                        {
                            try
                            {

                                Console.Write("What's the name of the song?: ");
                                string musicName = Console.ReadLine()!;
                                Console.Write("How long is the song in minutes?: ");
                                int musicDuration = int.Parse(Console.ReadLine()!);
                                Music music = new Music(musicName, kvp.Key, musicDuration, true);
                                registeredBands[kvp.Key].Albums[i].AddMusic(music);
                                Console.WriteLine($"{music.Name} added succesfully!");
                                Thread.Sleep(2000);

                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Invalid input: {e.Message}");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                        } while (true);


                    }
                    else
                    {
                        Console.WriteLine($"{userInput} not found!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No albums are currently registered!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();   
        }
        
    }

}
