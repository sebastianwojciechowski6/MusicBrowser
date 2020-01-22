using Xunit;
using appLogic;


namespace appXUnitTests
{
    /// <summary>
    /// Testing Artist.cs
    /// </summary>
    public class ArtistTest
    {
        /// <summary>
        /// Checks the Name property of Artist object.
        /// </summary>
        [Fact]
        public void NewArtist_CheckIfNameIsCorrect()
        {
            Artist artist = new Artist("The Beatles", "George Harrison, John Lennon, Paul McCartney, Pete Best, Richard Starkey, Stuart Sutcliffe", "England");

            Assert.Equal(expected: "The Beatles", actual: artist.Name);
        }
        
        /// <summary>
        /// Checks the Country property of Artist object.
        /// </summary>
        [Fact]
        public void NewArtist_CheckIfCountryIsCorrect()
        {
            Artist artist = new Artist("Whatever", "Whoever", "USA");

            Assert.Equal(expected: "USA", actual: artist.Country);
        }
        
        /// <summary>
        /// Checks the Members property of Artist object.
        /// </summary>
        [Fact]
        public void NewArtist_CheckIfMembersAreCorrect()
        {
            Artist artist = new Artist("Whatever", "Whoever", "USA");

            Assert.Equal(expected: "Whoever", actual: artist.Members);
        }

    }
}
