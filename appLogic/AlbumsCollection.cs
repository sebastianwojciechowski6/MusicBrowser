using System.Collections.Generic;
using System.Linq;

namespace appLogic
{
    public class AlbumsCollection
    {
        private List<Album> _albums = new List<Album>();

        // Create AddRange method which adds all albums given into parameter to _album collection
        public void AddAlbum(Album album)
        {
            _albums.Add(album);
        }

        // Create AllGenres collection and add all genres to it using LINQ
        public IEnumerable<string> AllGenres => _albums.Select(x => x.Genre).Distinct();

        // Create AlbumByGenres collection and add all albums that are in specific Genre
        public ILookup<string, Album> AlbumsByGenres => _albums.ToLookup(x => x.Genre);
        public ILookup<string, Album> AlbumsByStyles => _albums.ToLookup(x => x.Genre);
        

        public void AddAlbumsToCollection()
        {
            var allFilters = new Filters();
            var artistsCollection = new ArtistsCollection();
            
            var albumName = "Fat Joints Volume 1";
            var albumGenre = "Hip Hop";
            var albumStyle = "Hardcore Hip Hop";
            ushort albumYear = 2004;
            var albumDescription = "OG latino rap made by Sen Dog.";
            
            var tempArtist = new Artist("Sen Dog", "Cuban raper from Cypress Hill group.", "Senen Reyes", "Cuba");
            artistsCollection.AddArtist(tempArtist);
            
            
            var tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre,
                albumStyle, albumYear, albumDescription, allFilters);
            AddAlbum(tempAlbum);

            albumName = "Eminem Is Back";
            albumStyle = "Gangsta";
            albumDescription = "The famous rapper is back.";
            
            tempArtist = new Artist("Eminem", "American raper also called Slim Shady.", "Marshall Bruce Mathers III", "United States");
            artistsCollection.AddArtist(tempArtist);
            
            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, albumDescription, allFilters);

        }
    }
}