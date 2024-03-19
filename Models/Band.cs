using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Models;

public class Band
{
    private List<Album> albums = new List<Album>();

    private List<int> ratings = new List<int>();
    public string Name { get; set; }
    public List<Album> Albums { get { return albums; } set { albums = value; } }

    public List<int> Ratings { get { return ratings; } set { ratings = value; } }



    public Band() { }

    public Band(string name, List<Album> albums) 
    {
        Albums = albums;
        Name = name;
    
    }

    

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AddRating(int rate)
    {
        Ratings.Add(rate);
    }

    public void DisplayAlbums()
    {
        Console.WriteLine($"\nEvery album from {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Name: {album.Name}");
            Console.WriteLine($"Total Duration: {album.TotalDuration} minutes");
            album.DisplayAlbum();
        }
    }
}
