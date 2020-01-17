using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appLogic;

namespace appUnitTests
{
    [TestClass]
    public class FiltersTest
    {
        [TestMethod]
        public void TestListAddValues()
        {
            Album album = new Album("Sword of death","Metal", "Death Metal", 1998, "Recorded during cold day day", "Germany");

            var expected = "Metal";

            Assert.Equals(expected, )
        }
    }
}
