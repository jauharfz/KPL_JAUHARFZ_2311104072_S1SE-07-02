class YoutubeVideo
{
    private readonly int id;
    private readonly string title;
    public int playCount { get; set; }

    public YoutubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int time)
    {
        playCount += time;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}, TITLE: {title}, PLAY_COUNT: {playCount}");
    }
}

class Program
{
    static void Main()
    {
        var _youtubeVideo = new YoutubeVideo("Tutorial Design By Contract - jauharfz");
        _youtubeVideo.PrintVideoDetails();
    }
}