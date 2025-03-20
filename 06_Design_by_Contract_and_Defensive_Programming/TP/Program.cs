using System.Diagnostics.Contracts;

class YoutubeVideo
{
    private readonly int _id;
    private readonly string _title;
    public int PlayCount { get; set; }

    public YoutubeVideo(string title)
    {
        Contract.Requires(title.Length < 100 && !string.IsNullOrEmpty(_title),
            "TIDAK ADA JUDUL FILM YANG LEBIH DARI 100 HURUF !");
        Random random = new Random();
        _id = random.Next(10000, 100000);
        _title = title;
        PlayCount = 0;
        Contract.Ensures(_title.Length < 100 && !string.IsNullOrEmpty(_title));
    }

    [ContractInvariantMethod]
    protected void ObjectVariant()
    {
        Contract.Invariant(PlayCount >= 0);
    }

    public void IncreasePlayCount(int time)
    {
        Contract.Requires(time < 10000000, "timdak bomleh lebih dari 10m perinput yh");
        try
        {
            checked
            {
                PlayCount += time;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"sebaiknya jangan dibesarbesarkan -> {e}");
            throw;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"_id: {_id}, TITLE: {_title}, PLAY_COUNT: {PlayCount}");
    }
}

class Program
{
    static void Main()
    {
        var youtubeVideo = new YoutubeVideo("Tutorial Design By Contract - jauharfz");
        youtubeVideo.PrintVideoDetails();
        for (int i = 0; i < 1000; i++)
        {
            youtubeVideo.IncreasePlayCount(10000000 - 1);
            Console.WriteLine($"{i + 1}.UPDATE_PLAY_COUNT: {youtubeVideo.PlayCount}");
        }
    }
}