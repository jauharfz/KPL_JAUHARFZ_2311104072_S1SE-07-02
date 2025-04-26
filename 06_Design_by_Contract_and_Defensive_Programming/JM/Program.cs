using jmmodul6_2311104072;
List<YouTubeVideo> youTubeVideos = new List<YouTubeVideo>()
{
    new YouTubeVideo("Ini"),
    new YouTubeVideo("Adalah"),
    new YouTubeVideo("Rekomendasi"),
    new YouTubeVideo("Video"),
    new YouTubeVideo("Youtube"),
    new YouTubeVideo("Dari"),
    new YouTubeVideo("Saya"),
    new YouTubeVideo("Sendiri"),
    new YouTubeVideo("Ok"),
    new YouTubeVideo("Selesai")
};
YouTubeUser youTubeUser = new YouTubeUser(youTubeVideos, "jauharfz");
youTubeUser.PrintAllVideoPlayCount();