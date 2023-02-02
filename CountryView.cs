using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name}  {DisplayCountry.continent}");
            Console.WriteLine("colors:");
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
        
    }
}
