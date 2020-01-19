using System.Net.NetworkInformation;

namespace appLogic
{
    public class Track
    {
        public string Artist { get; }
        public string Title { get; }
        public string Duration { get; }

        public Track(string artist, string title, string duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }
    }
}