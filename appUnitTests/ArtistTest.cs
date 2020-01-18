using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appLogic;

namespace appLogicTests
{
    [TestClass]
    public class ArtistTest
    {
        [TestMethod]
        public void CreateArtistAndTestName()
        {
            var artist = new Artist("janusz", "hip-hop", "Janusz Cygan", "Poland");
            var excepted = "janusz";
            Assert.AreEqual(artist.Name, excepted);
        }
    }
}
