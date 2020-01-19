using System.Collections.Generic;
using System.Linq;

namespace appLogic
{
    public class AlbumsCollection
    {
        private List<Album> _albums = new List<Album>();
        // Create AddRange method which adds all albums given into parameter to _album collection
        public void AddRange(IEnumerable<Album> albums)
        {
            _albums.AddRange(albums);
        }
        // Create AllGenres collection and add all genres to it using LINQ
        public IEnumerable<string> AllGenres => _albums.Select(x => x.Genre).Distinct();
        // Create AlbumByGenres collection and add all albums that are in specific Genre
        public ILookup<string, Album> AlbumsByGenres => _albums.ToLookup(x => x.Genre);

        public void AddAlbumsToCollection()
        {
            var allFilters = new Filters();
            var allAlbums = new Album[]
            {
               //new Album("Fat Joints Volume 1",new Artist("Sen Dog", "Latino raper known from Cypress Hill group.", "Senen Reyes", "Cuba"), "Hip Hop","Hardcore Hip Hop",2004,"Latino old school hip hop from the streets.", allFilters),
            };
        }
    }
}