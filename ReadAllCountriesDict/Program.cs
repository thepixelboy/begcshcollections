using System;
using System.Collections.Generic;
using System.IO;

namespace ReadAllCountriesDict
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remember to change the path to the CSV file
            string filePath = Path.Combine(@"C:\Users\ruben\Projects\begcshcollections\", "countrypop-by-largest.csv");
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if (!gotCountry)
                Console.WriteLine($"Sorry, there is no country with the code, {userInput}");
            else
                Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
        }
    }
}
