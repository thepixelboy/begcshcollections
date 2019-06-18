using System;
using System.Collections.Generic;
using System.IO;

namespace ReadAllCountriesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remember to change the path to the CSV file
            string filePath = Path.Combine(@"C:\Users\ruben\Projects\begcshcollections\", "countrypop-by-largest.csv");
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);

            Console.Write("Enter no. of countries to display > ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            int maxToDisplay = userInput;
            for (int i = 0; i < countries.Count; i++) // List order forward
            //for (int i = countries.Count - 1; i >= 0; i--) // List order backwards
            {
                //int displayIndex = countries.Count - 1 - i;
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit > ");
                    if (Console.ReadLine() != "")
                        break;
                }

                Country country = countries[i];
                Console.WriteLine($"{i + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }            
        }
    }
}
