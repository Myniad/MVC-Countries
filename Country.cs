using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class Country
    {
        public string Name { get; set; }
        public string continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string _name, string _contienent, List<string> _colors)
        {
            Name = _name;
            continent= _contienent;
            Colors = _colors;
        }



    }

   
}
