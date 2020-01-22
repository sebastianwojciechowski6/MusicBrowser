using System;
using System.Linq;
using appLogic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace appXUnitTests
{
    public class AlbumsCollectionTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public AlbumsCollectionTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void GetAllGenresFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.AddAlbumsToCollection();

            foreach (var genre in collection.AllGenres)
                _testOutputHelper.WriteLine(genre);
        }

        [Fact]
        public void GetAllStylesFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.AddAlbumsToCollection();

            foreach (var style in collection.AllStyles)
                _testOutputHelper.WriteLine(style);
        }

        [Fact]
        public void GetAllYearsFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.AddAlbumsToCollection();

            foreach (var year in collection.AllYears)
                _testOutputHelper.WriteLine(year.ToString());
        }

        [Fact]
        public void GetAllCountriesFromAlbums()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.AddAlbumsToCollection();

            foreach (var country in collection.AllCountries)
                _testOutputHelper.WriteLine(country);

        }

        [Fact]
        public void GetAllAlbumsWithArtists()
        {
            AlbumsCollection collection = new AlbumsCollection();
            collection.AddAlbumsToCollection();

            var albumName = collection._albums;
            foreach (var el in albumName)
            {
                _testOutputHelper.WriteLine($"Album: {el.Name}, Artist: {el.Artist.Name}");
            }
        }

        [Fact]
        public void GetSpecifiedAlbumNamesByStyle()
        {
            AlbumsCollection collection = new AlbumsCollection();
            string style = "Proggresive Rock";
            collection.AddAlbumsToCollection();

            var specifiedAlbum = collection._albums.Where(x => x.Style == style).Select(x => x.Name);
            foreach (var el in specifiedAlbum)
                _testOutputHelper.WriteLine(el);
        }
    }
}
