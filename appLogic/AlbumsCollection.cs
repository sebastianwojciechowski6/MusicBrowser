using System.Collections.Generic;
using System.Linq;

namespace appLogic
{
    public class AlbumsCollection
    {
        private List<Album> _albums = new List<Album>();
        public void AddRange(IEnumerable<Album> albums)
        {
            _albums.AddRange(albums);
        }

        public IEnumerable<string> AllGenres => _albums.Select(x => x.Genre).Distinct();
        public ILookup<string, Album> AlbumsByGenres => _albums.ToLookup(x => x.Genre);
    }
}