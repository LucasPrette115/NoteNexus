

using NoteNexus.Interfaces;

namespace NoteNexus.Models;

internal class Band : IRateable
{
    private List<Album> albums = new List<Album>();

    private List<Ratings> ratingsList = new List<Ratings>();
    public string Name { get; set; }
    public List<Album> Albums => albums;

    public double AverageRating
    {
        get
        {
            if (ratingsList.Count == 0) return 0;
            else return ratingsList.Average(a => a.Rating);
        }
    }
    

    public Band() { }

    public Band(string name, List<Album> albums) 
    {
        this.albums = albums;
        Name = name;
    
    }

    

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Ratings rate)
    { 
        ratingsList.Add(rate);
    }

    public void DisplayAlbums()
    {
        Console.WriteLine($"\nEvery album from {Name}");
        foreach (Album album in Albums)
        {
            Console.WriteLine($"Name: {album.Name}");
            Console.WriteLine($"Total Duration: {album.TotalDuration} minutes\n");
            album.DisplayAlbum();
        }
    }
}
