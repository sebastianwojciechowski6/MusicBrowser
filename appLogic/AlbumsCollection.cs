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
            ushort albumYear = 2006;

            var tempArtist = new Artist("Sen Dog", "Senen Reyes", "Cuba");
            artistsCollection.AddArtist(tempArtist);
            
            var tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Eminem Is Back";
            albumStyle = "Gangsta";
            
            tempArtist = new Artist("Eminem", "Marshall Bruce Mathers III", "United States");
            artistsCollection.AddArtist(tempArtist);
            
            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "The Wall";
            albumGenre = "Rock";
            albumStyle = "Proggresive Rock";
            albumYear = 1979;

            tempArtist = new  Artist("Pink Floyd", "David Gilmour, Nick Mason, Rado Klose, Richard Wright, Roger Waters, Syd Barrett", "England");
            artistsCollection.AddArtist(tempArtist);

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


        }
    }
}