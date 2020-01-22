using System.Collections.Generic;

namespace appLogic
{
    /// <summary>
    /// The ArtistsCollection class contains methods that do simple operations on a collection.
    /// </summary>
    public class ArtistsCollection
    {
        /// <summary>
        /// Collection of Artist objects.
        /// </summary>
        private List<Artist> _artists = new List<Artist>();

        /// <summary>
        /// Adds <paramref name="artist"/> to collection.
        /// </summary>
        /// <param name="artist"></param>
        public void AddArtist(Artist artist)
        { 
            _artists.Add(artist);
        }
        
        /// <summary>
        /// Remove <paramref name="artist"/> from collection.
        /// </summary>
        /// <param name="artist"></param>
        public void RemoveArtist(Artist artist)
        {
            _artists.Remove(artist);
        }
        
        /// <summary>
        /// Gets Artist based which has specified <param name="name"></param>
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Artist object</returns>
        public Artist GetArtist(string name) 
        {
            var result = _artists.Find(el => el.Name == name);
            return result;
        }
    }
}