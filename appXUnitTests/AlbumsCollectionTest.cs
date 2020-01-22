using System.Linq;
using appLogic;
using Xunit;
using Xunit.Abstractions;

namespace appXUnitTests
{
    /// <summary>
    /// Testing AlbumsCollection.cs
    /// </summary>
    public class AlbumsCollectionTest
    {
        /// <summary>
        /// Auxiliary variable for testing output.
        /// </summary>
        private readonly ITestOutputHelper _testOutputHelper;

        /// <summary>
        /// AlbumsCollectionTest constructor.
        /// </summary>
        /// <param name="testOutputHelper"></param>
        public AlbumsCollectionTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// Shows Genres of added Albums.
        /// </summary>
        [Fact]
        public void GetAllGenresFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.CreateAlbums();

            foreach (var genre in collection.AllGenres)
                _testOutputHelper.WriteLine(genre);
        }
        
        /// <summary>
        /// Shows Styles of added Albums.
        /// </summary>
        [Fact]
        public void GetAllStylesFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.CreateAlbums();

            foreach (var style in collection.AllStyles)
                _testOutputHelper.WriteLine(style);
        }
        
        /// <summary>
        /// Shows Years of added Albums.
        /// </summary>
        [Fact]
        public void GetAllYearsFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.CreateAlbums();

            foreach (var year in collection.AllYears)
                _testOutputHelper.WriteLine(year.ToString());
        }

        /// <summary>
        /// Shows Countries of added Albums.
        /// </summary>
        [Fact]
        public void GetAllCountriesFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.CreateAlbums();

            foreach (var country in collection.AllCountries)
                _testOutputHelper.WriteLine(country);

        }
        /// <summary>
        /// Shows Albums and Artists.
        /// </summary>
        [Fact]
        public void GetAllAlbumsWithArtists()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.CreateAlbums();

            var albumName = collection.albums;
            foreach (var el in albumName)
            {
                _testOutputHelper.WriteLine($"Album: {el.Name}, Artist: {el.Artist.Name}");
            }
        }
        
        /// <summary>
        /// Shows an Album Name for a specified Style.
        /// </summary>
        [Fact]
        public void GetSpecifiedAlbumNamesByStyle()
        {
            AlbumsCollection collection = new AlbumsCollection();
            string style = "Proggresive Rock";
            collection.CreateAlbums();

            var specifiedAlbum = collection.albums.Where(x => x.Style == style).Select(x => x.Name);
            foreach (var el in specifiedAlbum)
                _testOutputHelper.WriteLine(el);
        }
    }
}
