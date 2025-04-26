using System.Threading.Channels;

namespace jmmodul6_2311104072;

public class YouTubeVideo
{
    private readonly int _id;
    public string Title { get;}
    public int PlayCount { get; private set; }


    public YouTubeVideo(string title)
    {
        Random rnd = new Random();
        _id = rnd.Next(1, 100000);
        Title = title;
        PlayCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        PlayCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"TITLE: {Title}");
        Console.WriteLine($"PLAY_COUNT: {PlayCount}");
    }
}