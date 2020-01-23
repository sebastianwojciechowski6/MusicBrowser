using System.Collections.Generic;

namespace appLogic
{
    public class Filters
    {
        public List<string> Genres = new List<string>();
        public List<string> Styles = new List<string>();
        public List<ushort> Years = new List<ushort>();
        public List<string> Countries = new List<string>();

        public void AddInfos(string genre, string style, ushort year, string country)
        {
            Genres.Add(genre);
            Styles.Add(style);
            Years.Add(year);
            Countries.Add(country);
        }

        public SortedList<string, uint> genresOcurrences = new SortedList<string, uint>();

    }
}