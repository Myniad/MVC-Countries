using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        List<Country> CountryDB = new List<Country>()
        {
            new Country("US","NA",),
            new Country("","",""),
            new Country("","",""),
            new Country("","","")
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {



            Console.WriteLine("Hellom welcome to the country app. Please select a country from the following list.");
            CountryListView view = new CountryListView();
            view.Display();
            foreach(Country c in CountryDB)
            {
                CountryAction(c);
            }
        }



    }



}
