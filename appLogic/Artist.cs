using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLogic
{
    public class Artist
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Members { get; set; }
        public string Country { get; set; }

        public Artist(string name, string description, string members, string country)
        {
            Name = name;
            Description = description;
            Members = members;
            Country = country;
        }
    }
}
