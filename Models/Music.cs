using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NoteNexus.Models;


 internal class Music
{
    private string? _name;
    private string? _artist;
    private int _duration;
    private bool _available;

    public Music(string name, string artist, int duration, bool available)
    {
        _name = name;
        _artist = artist;
        _duration = duration;
        _available = available;
    }

    public Music() { }

    public string Name
    {
        get { return _name!; }
        set { _name = value; }
    }

    public string Artist
    {
        get { return _artist!; }
        set { _artist = value; }
    }    
        
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public bool Available
    {
        get { return _available; }
        set { _available = value; }
    }

    public string Description => $"The music {_name} belongs to {_artist}";

    public void DisplayMusic()
    {
        string availability = Available ? "Available" : "Not Available"; 
        Console.WriteLine($"Name: {_name}" +
            $"\nArtist: {_artist}" +
            $"\nDuration: {_duration} min" +
            $"\nAvailable: {availability}" +
            $"\nDescription: {Description}");
    }

    

}
