using System.Diagnostics.Contracts;
using System.Threading.Channels;

namespace jmmodul6_2311104072;

public class YouTubeVideo
{
    private readonly int _id;
    public string Title { get;}
    public int PlayCount { get; set; }


    public YouTubeVideo(string title)
    {
        Contract.Requires(title.Length <= 200, "Judul Video Maksimal 200 karakter !");
        Contract.Requires(title != null,"Judul Video tidak boleh null !");
        Random rnd = new Random();
        _id = rnd.Next(1, 100000);
        Title = title;
        PlayCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count <= 25000000,"Play Count maksimal 25jt");
        Contract.Requires(count > 0,"Play Count tidak boleh negatif");
        try
        {
            checked
            {
                PlayCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"TITLE: {Title}");
        Console.WriteLine($"PLAY_COUNT: {PlayCount}");
    }
}