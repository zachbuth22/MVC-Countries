using System;
namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDB = new List<Country>()
        {
            new Country("USA", "North America", "Red", "White", "Blue"),
            new Country("Japan", "Asia", "White", "Red"),
            new Country("Kenya", "Africa","Black", "Red", "Green"),
 
        };

        public void CountryAction()
        {
            CountryListView listView = new CountryListView(CountryDB);
            listView.Display();

            //ask for input
            Console.WriteLine("Please pick a Country number");
            int CountryChoice = int.Parse(Console.ReadLine());

            Country i = CountryDB[CountryChoice];
            CountryView view = new CountryView(i);
            view.Display();
        }
    }
}

