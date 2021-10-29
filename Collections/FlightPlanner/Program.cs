using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "D:/Codelex/csharp-basics-exercises/Collections/FlightPlanner/flights.txt";
        private static void Main(string[] args)
        {
            List<string> readText = File.ReadLines(Path).ToList();
            HashSet<string> cities = new HashSet<string>();

            foreach (var rout in readText)
            {
                var array = rout.Split('-','>');
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0)
                    {
                        cities.Add(array[i].Trim());
                    }
                }
            }

            Dictionary<int, string> citiesForSelect = new Dictionary<int, string>();
            var number = 1;
            foreach (var item in cities)
            {
                citiesForSelect.Add(number, item);
                number++;
            }
            cities.Clear();

            foreach (var city in citiesForSelect)
            {
                Console.WriteLine($"{city.Key} {city.Value}");
            }

            Console.Write("select a city from which to start: ");
            int selectedCityNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string selectedCity = "";
            string startCity = "";
            foreach (var city in citiesForSelect)
            {
                if (selectedCityNumber == city.Key)
                {
                    selectedCity = city.Value;
                    startCity = city.Value;
                }
            }

            string selectedRout = "";
            var choice = 1;
            while (choice != 0)
            {
                foreach (var rout in readText)
                    {
                    var array = rout.Split('-', '>');
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[0].Trim()==selectedCity)
                        {
                            if (i == 2)
                            {
                                cities.Add(array[i].Trim());
                            }
                        }
                    }
                }

                citiesForSelect.Clear();
                number = 1;
                foreach (var item in cities)
                {
                    citiesForSelect.Add(number, item);
                    number++;
                }
                cities.Clear();

                foreach (var city in citiesForSelect)
                {
                    Console.WriteLine($"{city.Key} {city.Value}");
                }

                Console.WriteLine("To exit program press 0");
                Console.Write("Select next city: ");
                selectedCityNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                foreach (var city in citiesForSelect)
                {
                    if (selectedCityNumber == city.Key)
                    {
                        selectedCity = city.Value;

                        if (startCity == selectedCity)
                        {
                            selectedRout += city.Value;
                            choice = 0;
                        }
                        else
                        selectedRout += city.Value + " -> ";
                    }
                }
            }

            Console.WriteLine($"Your rout: {startCity} -> {selectedRout}");
            Console.ReadKey();
        }
    }
}
