using Xunit;
using appLogic;

namespace appLogicTests
{
    public class FiltersTest
    {
        [Fact]
        public void TestListAddValues()
        {
            var allFilters = new Filters();
            Album album = new Album("Sword of death", new Artist("Jacek Cygan", "Fajny gość", "Jacek Cygan", "Polska"),
                "Metal", "Death Metal", 1998, "Recorded during cold day day", allFilters);

            var expected = "Metal";

            Assert.Equal(expected, allFilters.Genres[0]);
        }
    }
}