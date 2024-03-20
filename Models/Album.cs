using NoteNexus.Menus;

namespace NoteNexus.Models;

internal class Album
{
    public List<Music> musics = new List<Music>();
    public string? Name { get; set; }
    public List<Music> Musics { get { return musics; } set { musics = value; } }

    public int TotalDuration => musics.Sum(m => m.Duration);


    public Album() { }
    public Album(string name, List<Music> musics) { Name = name; Musics = musics; }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void DisplayAlbum()
    {
        Menu.DisplayTitle($"\nSongs from {Name}");
        foreach (var music in musics)
        {
            music.DisplayMusic();
            Console.WriteLine("\n");
        }
        Console.WriteLine($"Total duration: {TotalDuration} minutes");
    }

    public Album Parse(string text)
    {
        return new Album(text, new List<Music>());

    }
}
