using NoteNexus.Menus;
using NoteNexus.Interfaces;



namespace NoteNexus.Models;

internal class Album : IRateable
{
    private List<Music> _musics;

    private List<Ratings>? _ratings;
    public string Name { get; set; }
    public List<Music>? Musics { get { return _musics; } set { _musics = value; } }
    public List<Ratings>? Ratings { get { return _ratings; } set { _ratings = value; } }
    public int TotalDuration => _musics.Sum(m => m.Duration);

    public double AverageRating
    {
        get
        {
            if (Ratings.Count == 0) return 0;
            else return Ratings.Average(a => a.Rating);
        }
    }


    public Album() 
    {
        
        Musics = new List<Music>();
        Ratings = new List<Ratings>();
    }
    public Album(string name, List<Music> musics)
    {
        Name = name; 
        Musics = new List<Music>();
        Ratings = new List<Ratings>();
    }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }
    public void AddRating(Ratings rate)
    {
        Ratings.Add(rate);
    }


    public void DisplayAlbum()
    {
        Menu.DisplayTitle($"\nSongs from {Name}");
        foreach (var music in Musics)
        {
            music.DisplayMusic();
            Console.WriteLine("\n");
        }
        Console.WriteLine($"Total duration: {TotalDuration} minutes");
        Console.WriteLine($"Average rating: {AverageRating}");
    }

    public static Album Parse(string text)
    {
        return new Album(text, new List<Music>());

    }
}
