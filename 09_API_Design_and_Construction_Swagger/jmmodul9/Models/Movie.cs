namespace jmmodul9.Models;

public class Movie
{
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public List<string> Stars { get; set; } = new List<string>();
    public string Description { get; set; } = string.Empty;

    public Movie()
    {
        Stars = new List<string>();
    }

    public Movie(string title, string director, List<string> stars, string description)
    {
        Title = title;
        Director = director;
        Stars = stars ?? new List<string>();
        Description = description;
    }
}