namespace appLogic
{
    public class Album
    {
        public string Name { get; }
        public Artist Artist { get; }
        public string Genre { get; }
        public string Style { get; }
        public ushort Year { get; }
        public string Country { get; }

        public Album(string name, Artist artist, string genre, string style, ushort year, Filters allFilters)
        {
            Name = name;
            Artist = artist;
            Genre = genre;
            Style = style;
            Year = year;
            Country = artist.Country;

            allFilters.AddInfos(genre, style, year, artist.Country);
        }
    }
}
