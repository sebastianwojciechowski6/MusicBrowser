//using Xunit;
//using appLogic;

//namespace appLogicTests
//{
//    public class FiltersTest
//    {
//        [Fact]
//        public void TestAddAlbumFiltersOneRecord()
//        {
//            var allFilters = new Filters();
//            var artist = new Artist("Jacek Cygan", "Fajny gość", "Jacek Cygan", "Polska");
//            Album album = new Album("Sword of death", "Metal", "Death Metal", 1998, "Recorded during cold day day", new Track(artist, "tete", "6:50"), allFilters);

//            var expected = "Metal";

//            Assert.Equal(expected, allFilters.Genres[0]);
//        }

//        [Fact]

//        public void TestAddAlbumFiltersTwoRecords()
//        {
//            var allFilters = new Filters();


//        }
//    }
//}