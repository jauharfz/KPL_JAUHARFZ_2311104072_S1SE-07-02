using System.Diagnostics.Contracts;

namespace jmmodul6_2311104072;

public class YouTubeUser
{
    private readonly int _id;
    public List<YouTubeVideo> _uploadedVideos;
    private readonly string _username;

    public YouTubeUser(string username)
    {
        Contract.Requires(username.Length <= 100,"Username max 100 karakter");
        Contract.Requires(username != null,"Uername tidak boleh null");
        Random rnd = new Random();
        _id = rnd.Next(1, 100000);
        _uploadedVideos = new List<YouTubeVideo>();
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
        Contract.Requires(youTubeVideo!= null,"Video tidak boleh null");
        Contract.Requires(youTubeVideo.PlayCount < int.MaxValue, "Play Count pada Video harus kurang dari Max Integer");
        _uploadedVideos.Add(youTubeVideo);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {_username}");
        for (int i = 0; i < _uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i+1} judul: {_uploadedVideos[i].Title}");
        }
        Contract.Ensures(_uploadedVideos.Count <= 8);
        
    }
}