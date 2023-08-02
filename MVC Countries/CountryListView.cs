using System;
namespace MVC_Countries
{
	public class CountryListView
	{
        //prop
        public List<Country> AllCountries { get; set; }

        //con
        public CountryListView(List<Country> _allCountries)
        {
            AllCountries = _allCountries;
        }

        //methods

        public void Display()
        {
            for (int i = 0; i < AllCountries.Count; i++)
            {
                Console.WriteLine($"{i}. {AllCountries[i].Name}");
            }
        }
    }
}

