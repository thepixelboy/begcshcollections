using System;
using System.Collections.Generic;
using System.IO;

namespace ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remember to change the path to the CSV file
            string filePath = Path.Combine(@"C:\Users\ruben\Projects\begcshcollections\", "countrypop-by-largest.csv");
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
