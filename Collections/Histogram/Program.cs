using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var dictionary = InitDictionary();
            foreach (var s in readText.Split(' ').ToList())
            {
                var score = int.Parse(s);
                foreach (var item in dictionary.Keys.ToList())
                {
                    var value = item.Split('-');
                    if (score == int.Parse(value[0]))
                    {
                        dictionary[item] += "*";
                    }
                    else if(score >= int.Parse(value[0]) && score <= int.Parse(value[1]))
                    {
                        dictionary[item] += "*";
                    }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadKey();
        }

        public static Dictionary<string, string> InitDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("00-09",string.Empty);
            dictionary.Add("10-19",string.Empty);
            dictionary.Add("20-29",string.Empty);
            dictionary.Add("30-39",string.Empty);
            dictionary.Add("40-49",string.Empty);
            dictionary.Add("50-59",string.Empty);
            dictionary.Add("60-69",string.Empty);
            dictionary.Add("70-79",string.Empty);
            dictionary.Add("80-89",string.Empty);
            dictionary.Add("90-99",string.Empty);
            dictionary.Add("  100", string.Empty);

            return dictionary;
        } 
    }
}
