using System.Net.NetworkInformation;

namespace appLogic
{
    public class Track
    {
        public Artist Artist { get; }
        public string Title { get; }
        public string Duration { get; }

        public Track(Artist artist, string title, string duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }
    }
}