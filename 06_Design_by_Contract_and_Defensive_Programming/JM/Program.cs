using System.Numerics;
using jmmodul6_2311104072;

YouTubeUser youTubeUser = new YouTubeUser("jauharfz");
string[] videoTitle =
{
    "Video Pertama",
    "Video Kedua",
    "Video Ketiga",
    "Video Keempat",
    "Video Kelima",
    "Video Keenam",
    "Video Ketujuh",
    "Video Kedelapan",
    "Video Kesembilan",
    "Video Kesepuluh"
};
foreach (var video in videoTitle)
{
    YouTubeVideo youTubeVideo = new YouTubeVideo(video);
    youTubeUser.AddVideo(youTubeVideo);
}

youTubeUser.PrintAllVideoPlayCount();
for (int i = 0; i < 1000; i++)
{
    foreach (var youTube in youTubeUser._uploadedVideos)
    {
        youTube.IncreasePlayCount(10000000 - 1);
        youTube.PrintVideoDetails();
    }
}