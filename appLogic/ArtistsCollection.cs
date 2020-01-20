using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLogic
{
    public class ArtistsCollection
    {
        public List<Artist> Artists = new List<Artist>();

        public void AddArtist(Artist artist)
        { 
            Artists.Add(artist);
        }

        public void RemoveArtist(Artist artist)
        {
            Artists.Remove(artist);
        }
        public Artist GetArtist(string name) 
        {
            var result = Artists.Find(el => el.Name == name);
            return result;
        }

        public string GetArtistName(string name)
        {
            List<Artist> result = Artists.FindAll(el => el.Name == name);

            foreach (var x in result)
                return $"Nazwa: {x.Name}, Opis: {x.Description}, Członkowie: {x.Members}, Kraj: {x.Country}";

            return result.ToString();
        }
    }
}