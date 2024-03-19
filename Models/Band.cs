using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Models;

internal class Band
{
    private List<Album> albums = new List<Album>();

    private List<Ratings> ratingsList = new List<Ratings>();
    public string Name { get; set; }
    public List<Album> Albums { get { return albums; } set { albums = value; } }

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
        Albums = albums;
        Name = name;
    
    }

    

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AddRating(Ratings rate)
    { 
        ratingsList.Add(rate);
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
