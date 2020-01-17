using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLogic
{
    public class Album
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Style { get; set; }
        public ushort Year { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public Album(string name, string genre, string style, ushort year, string description, string country)
        {
            Name = name;
            Genre = genre;
            Style = style;
            Year = year;
            Description = description;
            Country = country;
        }
        
        public void AddFilterRecords()
        {
            
        }
    }
}
