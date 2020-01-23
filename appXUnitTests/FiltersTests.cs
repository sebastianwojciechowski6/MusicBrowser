using Xunit;
using Xunit.Abstractions;
using appLogic;

namespace appXUnitTests
{
    /// <summary>
    /// Testing Filters.cs
    /// </summary>
    public class FiltersTests
    {
        /// <summary>
        /// Auxiliary variable for testing output.
        /// </summary>
        private readonly ITestOutputHelper _testOutputHelper;

        /// <summary>
        /// FiltersTests constructor.
        /// </summary>
        /// <param name="testOutputHelper"></param>
        public FiltersTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        [Fact]
        public void GenreOccurenceTester()
        {
            var albumsCollection = new AlbumsCollection();

            albumsCollection.AddAlbumsToCollection();
            albumsCollection.GetGenres();
        }
        
        /// <summary>
        /// Shows Genres and Ocurrences in created albums.
        /// </summary>
        [Fact]
        public void FiltersOcurrenceCounterTest()
        {
            var albumsCollection = new AlbumsCollection();
            
            albumsCollection.CreateAlbums();
            
            foreach (var el in albumsCollection.allFilters.Genres)
            {
                if (!albumsCollection.allFilters.genresOcurrences.ContainsKey(el))
                {
                    albumsCollection.allFilters.genresOcurrences.Add(el, 1);
                }
                else
                {
                    albumsCollection.allFilters.genresOcurrences[el] += 1;
                }
            }

            foreach (var (key, value) in albumsCollection.allFilters.genresOcurrences)
            {
                _testOutputHelper.WriteLine($"{key} {value}");
            
            }
        }
    }
}
