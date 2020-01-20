using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using appLogic;

namespace appXUnitTests
{
    public class FiltersTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

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
        
        [Fact]
        public void FiltersOcurrenceCounterTest()
        {
            var albumsCollection = new AlbumsCollection();
            
            albumsCollection.AddAlbumsToCollection();
            
            foreach (var el in albumsCollection.allFilters.Genres)
            {
                //_testOutputHelper.WriteLine(el);
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
