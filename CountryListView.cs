using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }



        public void Display()
        {
            foreach (var country in Countries)
            {
                Console.WriteLine($"{country.Name} {country.continent} {country.Colors}");
            }
        }

    }
}
