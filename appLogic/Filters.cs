using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
