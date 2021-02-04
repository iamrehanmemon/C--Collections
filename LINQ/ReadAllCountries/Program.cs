using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.BegCShCollections.ReadAllCountries
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"E:\Capgemini\Azure Training\C# Collections\LINQ\Pop by Largest Final.csv";
			CsvReader reader = new CsvReader(filePath);

			List<Country> countries = reader.ReadAllCountries();

			
			var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(20);
			//Link Query Syntax
			var filteredCountries2 =from country in countries
									where !country.Name.Contains(',')
									select country;

			// listing the first 20 countries without commas in their names
			foreach (Country country in filteredCountries)
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}

			Console.WriteLine();

			// listing the 10 highest population countries in alphabetical order.
			// Reverse Where() and Take() to see the impact of swapping chaining order round
			/*foreach (Country country in countries.Take(10).OrderBy(x=>x.Name))
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}*/

		}

	}
}
