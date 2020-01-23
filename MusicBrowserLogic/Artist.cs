namespace MusicBrowserLogic
{
    public class Artist
    {
        /// <summary>
        /// The Artist class contains properties and constructor.
        /// </summary>
        public string Name { get; }
        public string Members { get; }
        public string Country { get; }

        /// <summary>
        /// Artist class constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="members"></param>
        /// <param name="country"></param>
        public Artist(string name, string members, string country)
        {
            Name = name;
            Members = members;
            Country = country;
        }

    }
}
