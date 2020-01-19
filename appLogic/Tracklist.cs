using System.Collections.Generic;

namespace appLogic
{
    public class Tracklist
    {
        public List<Track> Tracks = new List<Track>();

        public Tracklist(IEnumerable<Track> track)
        {
            Tracks.AddRange(track);
        }
    }
}