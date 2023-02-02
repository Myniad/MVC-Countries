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
           new Country("United States", "North America", new List<string>() { "red", "white", "blue" }),
           new Country("Belize", "North America", new List<string>() { "red", "white", "blue" }),
           new Country("Costa Rica", "North America", new List<string>() { "blue", "white", "red" })
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            bool runProgram = true;
            while(runProgram)
            {
            CountryListView view = new CountryListView(CountryDB);
            Console.WriteLine("Hello welcome to the country app. Please select a country from the following list.");
            view.Display();

            int choice = int.Parse(Console.ReadLine());
            Country result = CountryDB[choice];
            CountryAction(result);





                while (true)
                {
                    Console.WriteLine("Do you want to continue? y/n");
                    string cCheck = Console.ReadLine();
                    if (cCheck == "y")
                    {
                        runProgram = true;
                        break;
                    }
                    else if (cCheck =="n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }



            
        }



    }



}
