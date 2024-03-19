

namespace NoteNexus.Models;

internal class Ratings
{

    public int Rating { get; }
    public Ratings(int rating)
    {
        Rating = rating;
    }

    public Ratings() { }

    public static Ratings Parse(string txt)
    {
        int rating = int.Parse(txt);
        return new Ratings(rating);
    }
}
