using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Models;

public class Podcast
{
    private List<Episode> episodes = new List<Episode>();
    public string? Host { get; set; }
    public string? Name { get; set; }
    public int TotalEpisodes { get; set; }

    public List<Episode> Episodes { get; set; }

    public Podcast() { }

    public Podcast(string host, string name, int totalEpisodes, List<Episode> episodes) 
    {
        Host = host;
        Name = name;
        TotalEpisodes = totalEpisodes;
        Episodes = episodes;

    }

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nDisplaying podcast details\n************************");

        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine("\nEvery Episode\n**************** ");
        foreach (Episode episode in episodes)
        {
            Console.WriteLine($"\nTitle: {episode.Title}" +
                $"\nTotal of episodes: {episodes.Count}");
            Console.Write("Guests: ");
            foreach (var guest in episode.Guests) { Console.WriteLine($"{guest}"); }
            

            
        }
    }
}
