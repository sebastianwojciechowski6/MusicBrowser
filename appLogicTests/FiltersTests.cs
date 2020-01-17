using Microsoft.VisualStudio.TestTools.UnitTesting;
using appLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class FiltersTest
{
    [TestMethod]
    public void TestListAddValues()
    {
        var allFilters = new Filters();
        Album album = new Album("Sword of death", new Artist("Jacek Cygan", "Fajny gość","Jacek Cygan" , "Polska"), "Metal", "Death Metal", 1998, "Recorded during cold day day", allFilters);

        var expected = "Metal";

        Assert.AreEqual(expected, allFilters.Genres[0]);
    }
}