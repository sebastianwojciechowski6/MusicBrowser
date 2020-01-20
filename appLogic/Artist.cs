using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLogic
{
    public class Artist
    {
        public string Name { get; }
        public string Members { get; }
        public string Country { get; }

        public Artist(string name, string members, string country)
        {
            Name = name;
            Members = members;
            Country = country;
        }

    }
}
