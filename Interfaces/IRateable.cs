

using NoteNexus.Models;

namespace NoteNexus.Interfaces;

internal interface IRateable
{
    void AddRating(Ratings rate);
    double AverageRating { get; }
}
