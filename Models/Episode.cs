

namespace NoteNexus.Models;

public class Episode
{

    private List<string> guests = new List<string>();
    public int Duration { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int Number { get; set; } 

    public List<string>? Guests { get; set; }

    public Episode() { }

    public Episode(int duration, string title, int number, List<string> guests)
    {
        Duration = duration;
        Title = title;
        Number = number;
        Guests = guests;
    }

    public void AddGuests(string guestName)
    {
        Guests.Add(guestName);
    }


}