using System.Collections.Generic;

namespace MusicBrowserLogic
{
    /// <summary>
    /// The ArtistsCollection class contains methods that do simple operations on a collection.
    /// </summary>
    public class ArtistsCollection
    {
        /// <summary>
        /// Collection of Artist objects.
        /// </summary>
        private List<Artist> Artists = new List<Artist>();

        /// <summary>
        /// Adds <paramref name="artist"/> to collection.
        /// </summary>
        /// <param name="artist"></param>
        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }

        /// <summary>
        /// Remove <paramref name="artist"/> from collection.
        /// </summary>
        /// <param name="artist"></param>
        public void RemoveArtist(Artist artist)
        {
            Artists.Remove(artist);
        }

        /// <summary>
        /// Gets Artist based which has specified <param name="name"></param>
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Artist object</returns>
        public Artist GetArtist(string name)
        {
            var result = Artists.Find(el => el.Name == name);
            return result;
        }
    }
}