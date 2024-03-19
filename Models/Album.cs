using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Models;

internal class Album
{
    private List<Music> musics = new List<Music>();
    public string? Name { get; set; }
    public List<Music> Musics { get; set; }

    public int TotalDuration => musics.Sum(m => m.Duration);


    public Album() { }
    public Album(string name, List<Music> musics) { Name = name; Musics = musics; }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbum()
    {
          
        Console.WriteLine($"\nSongs from {Name}\n**************");
        foreach (var music in musics)
        {
            music.DisplayMusic();
            Console.WriteLine("\n");
        }
        Console.WriteLine($"Total duration: {TotalDuration} minutes");
    }
}
