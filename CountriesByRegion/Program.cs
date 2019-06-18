using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountriesByRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remember to change the path to the CSV file
            string filePath = Path.Combine(@"C:\Users\ruben\Projects\begcshcollections\", "countrypop-by-largest.csv");
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            else
                Console.WriteLine("Taht is not a valid region");
        }
    }
}
