using System;
using System.IO;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remember to change the path to the CSV file
            string filePath = Path.Combine(@"C:\Users\ruben\Projects\begcshcollections\TopTenPops\", "countrypop-by-largest.csv");
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
