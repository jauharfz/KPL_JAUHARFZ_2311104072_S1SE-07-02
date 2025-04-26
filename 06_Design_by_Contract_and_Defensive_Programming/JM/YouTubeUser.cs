namespace jmmodul6_2311104072;

public class YouTubeUser
{
    private readonly int _id;
    private readonly List<YouTubeVideo> _uploadedVideos;
    private readonly string _username;

    public YouTubeUser(List<YouTubeVideo> uploadedVideos, string username)
    {
        Random rnd = new Random();
        _id = rnd.Next(1, 100000);
        _uploadedVideos = uploadedVideos;
        _username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int uploadedVideo = 0;
        foreach (var temp in _uploadedVideos)
        {
            uploadedVideo = temp.PlayCount;
        }

        return uploadedVideo;
    }

    public void AddVideo(YouTubeVideo youTubeVideo)
    {
        _uploadedVideos.Add(youTubeVideo);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {_username}");
        for (int i = 0; i < _uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i+1} judul: {_uploadedVideos[i].Title}");
        }
    }
}