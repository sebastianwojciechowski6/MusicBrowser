using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLogic
{
    public class ArtistInfo
    {
        List<Artist> Artists = new List<Artist>();

        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }

        public void RemoveArtist(Artist artist)
        {
            Artists.Remove(artist);
        }

        public void GetArtist(string name)
        {
            var result = Artists.FindAll(el => el.Name == name);

            foreach(var x in result)
                Console.WriteLine($"Nazwa: {x.Name},Opis: {x.Description}, Członkowie: {x.Members}, kraj: {x.Country}");
        }
    }
}