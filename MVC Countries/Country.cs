﻿using System;
namespace MVC_Countries
{
	public class Country
	{
		//props
		public string Name { get; set;}
		public string Continent { get; set; }
		public List <string> Colors { get; set; }

		//constructor
		public Country(string _name, string _continent, params string[] _colors)
		{
			Name = _name;
			Continent = _continent;
			Colors = _colors.ToList();
		}
	}
}

