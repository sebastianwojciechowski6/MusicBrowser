using System.Net.NetworkInformation;

namespace appLogic
{
    public class Tracklist
    {
        public Artist Artist { get; }
        public string Title { get; }
        public string Duration { get; }

        public Tracklist(Artist artist, string title, string duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }
    }
}