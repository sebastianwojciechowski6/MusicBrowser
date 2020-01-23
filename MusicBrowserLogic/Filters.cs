using System.Collections.Generic;

namespace MusicBrowserLogic
{
    /// <summary>
    /// The Filters class contains collections of all filters.
    /// </summary>
    public class Filters
    {
        /// <summary>
        /// Collections for each filter.
        /// </summary>
        public List<string> Genres = new List<string>();
        public List<string> Styles = new List<string>();
        public List<ushort> Years = new List<ushort>();
        public List<string> Countries = new List<string>();

        /// <summary>
        /// Adds <paramref name="genre"/> <paramref name="style"/> <paramref name="year"/> <paramref name="country"/> to collections.
        /// </summary>
        /// <param name="genre"></param>
        /// <param name="style"></param>
        /// <param name="year"></param>
        /// <param name="country"></param>
        public void AddInfos(string genre, string style, ushort year, string country)
        {
            Genres.Add(genre);
            Styles.Add(style);
            Years.Add(year);
            Countries.Add(country);
        }

        /// <summary>
        /// Creates a collection which is provided for having Genres ocurrences.
        /// </summary>
        public SortedList<string, uint> genresOcurrences = new SortedList<string, uint>();

        /// <summary>
        /// Creates a collection which is provided for having Styles ocurrences.
        /// </summary>
        public SortedList<string, uint> stylesOcurrences = new SortedList<string, uint>();

        /// <summary>
        /// Creates a collection which is provided for having Years ocurrences.
        /// </summary>
        public SortedList<ushort, uint> yearsOcurrences = new SortedList<ushort, uint>();

        /// <summary>
        /// Creates a collection which is provided for having Countries ocurrences.
        /// </summary>
        public SortedList<string, uint> countriesOcurrences = new SortedList<string, uint>();
    }
}