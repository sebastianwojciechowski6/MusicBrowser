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

        public Tracklist tempTracklist = new Tracklist(new Track[]
        {
            new Track("Sen Dog", "Head Trip", "3:41"),
            new Track("Rhyme Poetic Mafia", "What Cha Claimin [Remix]", "3:53"),
            new Track("Sen Dog, Guic-1, Frank Black", "Tha Coalition", "3:40"),
            new Track("Sen Dog, Guic-1", "Nigga With A Badge", "4:03"),
            new Track("Aztec", "Aztlan", "2:16"),
            new Track("O. Brown, Candice Francis", "Been Through So Much", "4:03"),
            new Track("Sen Dog, Mellow Man Ace", "Get Respect", "2:35"),
            new Track("Sen Dog", "The Sicko", "3:44"),
            new Track("O. Brown", "Some Wake Up", "4:27"),
            new Track("Sen Dog", "Break Em Up Homeboy", "3:25"),
            new Track("Sen Dog, Rhyme Poetic Mafia", "Deadly", "3:33"),
        });

        public void AddAlbumsToCollection()
        {
            var albumName = "Fat Joints Volume 1";
            var albumGenre = "Hip Hop";
            var albumStyle = "Hardcore Hip Hop";
            ushort albumYear = 2004;
            var albumDescription = "OG latino rap made by Sen Dog.";

            var allFilters = new Filters();
            

            /*var tempAlbum = new Album(albumName, , albumGenre,
                albumStyle, albumYear, albumDescription, tempTracklist, allFilters);
            AddAlbum(tempAlbum);*/
            

        }
    }
}