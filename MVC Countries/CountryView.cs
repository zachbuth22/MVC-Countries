using System;
namespace MVC_Countries
{
	public class CountryView
	{
		//props
		public Country DisplayCountry { get; set; }

		//constructor
		public CountryView(Country _Country)
		{
			DisplayCountry = _Country;
		}

		//methods
		public void Display()
		{
			Console.WriteLine($"Name: {DisplayCountry.Name} " +
				$"Continent: {DisplayCountry.Continent} Flag Colors: ");
			DisplayCountry.Colors.ForEach(c =>
			{
				Console.Write(c + " ");
			}
			);
		}
	}
}

