using System.Collections.Generic;
using System.Linq;

namespace appLogic
{
    /// <summary>
    /// The AlbumsCollection class is destined to generate albums and store them.
    /// </summary>
    public class AlbumsCollection
    {
        /// <summary>
        /// Collection that will store Album objects.
        /// </summary>
        public List<Album> albums = new List<Album>();
        
        /// <summary>
        /// Object that is used to create Album objects.
        /// </summary>
        public Filters allFilters = new Filters();
      
        /// <summary>
        /// Adds <paramref name="album"/> to albums collection.
        /// </summary>
        /// <param name="album">Album</param>
        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        /// <summary>
        /// Gets distinct Genres from albums collection using LINQ.
        /// </summary>
        public IEnumerable<string> AllGenres => albums.Select(x => x.Genre).Distinct();
        
        /// <summary>
        /// Gets distinct Styles from albums collection using LINQ.
        /// </summary>
        public IEnumerable<string> AllStyles => albums.Select(x => x.Style).Distinct();
        
        /// <summary>
        /// Gets distinct Years from albums collection using LINQ.
        /// </summary>
        public IEnumerable<ushort> AllYears => albums.Select(x => x.Year).Distinct();
        
        /// <summary>
        /// Gets distinct Countries from albums collection using LINQ.
        /// </summary>
        public IEnumerable<string> AllCountries => albums.Select(x => x.Country).Distinct();

        /// <summary>
        /// Creates Album objects based on created Artist objects and variables, adds Artist to albums collection.
        /// </summary>
        public void CreateAlbums()
        {
            var artistsCollection = new ArtistsCollection();
            
            var albumName = "Fat Joints Volume 1";
            var albumGenre = "Hip Hop";
            var albumStyle = "Hardcore Hip Hop";
            ushort albumYear = 2006;
            
            var tempArtist = new Artist("Sen Dog", "Senen Reyes", "Cuba");
            artistsCollection.AddArtist(tempArtist);
            
            var tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Ready To Die";
            albumYear = 1994;

            tempArtist = new Artist("The Notorious B.I.G.", "Christopher George Latore Wallace", "USA");
            artistsCollection.AddArtist(tempArtist);

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Eminem Is Back";
            albumStyle = "Gangsta";
            albumYear = 2004;
            
            tempArtist = new Artist("Eminem", "Marshall Bruce Mathers III", "USA");
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


            albumName = "Wish You Were Here";
            albumYear = 1975;

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Abbey Road";
            albumStyle = "Pop Rock";
            albumYear = 1969;

            tempArtist = new  Artist("The Beatles", "George Harrison, John Lennon, Paul McCartney, Pete Best, Richard Starkey, Stuart Sutcliffe", "England");
            artistsCollection.AddArtist(tempArtist);

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Master Of Puppets";
            albumStyle = "Thrash Metal";
            albumYear = 1986;

            tempArtist = new  Artist("Metallica", "James Hetfield, Cliff Burton, Kirk Hammett, Lars Ulrich", "USA");
            artistsCollection.AddArtist(tempArtist);

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Kill'Em All";
            albumYear = 1983;

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Ride The Lightning";
            albumYear = 1984;

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Painkiller";
            albumStyle = "Heavy Metal";
            albumYear = 1990;

            tempArtist = new Artist("Judas Priest", "Rob Halford, Glenn Tipton, K. K. Downing, Rob Halford", "England");
            artistsCollection.AddArtist(tempArtist);

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);


            albumName = "Scream For Vengeance";
            albumYear = 1982;

            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);

            albumName = "British Steel";
            albumYear = 1980;
            tempAlbum = new Album(albumName, artistsCollection.GetArtist(tempArtist.Name), albumGenre, albumStyle, albumYear, allFilters);
            AddAlbum(tempAlbum);
        }

        public void GetGenres()
        {
            var albums = new AlbumsCollection();
            foreach(var el in albums.allFilters.Genres)
            {
                if (!(albums.allFilters.genresOcurrences.ContainsKey(el)))
                    albums.allFilters.genresOcurrences.Add(el, 1);
                else albums.allFilters.genresOcurrences[el] += 1;
            }

            foreach(var el in albums.allFilters.genresOcurrences)
                System.Console.WriteLine($"{el.Key}, {el.Value}");
        }
    }
}