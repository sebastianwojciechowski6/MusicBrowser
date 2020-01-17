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

        public void GetArtist(Artist artist)
        {
            Console.WriteLine(Artists.FindAll(el => el.Equals ( artist ) ));
        }
    }

    class Test
    {
        static void Testing()
        {
            var artistinfo = new ArtistInfo();
            var artist = new Artist("janusz", "kelekle", "mememe");

            artistinfo.AddArtist(artist);

            artistinfo.GetArtist(artist);




        }
    }
}