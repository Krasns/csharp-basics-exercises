using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            
            List<string> cars = new List<string> ();
            foreach (var item in array)
            {
                cars.Add(item);
                Console.WriteLine(item);
            }
            Console.WriteLine();

            HashSet<string> auto = new HashSet<string>();
            foreach (var item in array)
            {
                auto.Add(item);
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            Dictionary<string, string> machine = new Dictionary<string, string>();
            foreach (var item in auto)
            {
                if (item == "Honda")
                {
                    machine.Add("Honda", "Japan");
                }
                else if (item == "Tesla")
                {
                    machine.Add("Tesla", "USA");
                }
                else
                {
                    machine.Add(item, "Germany");
                }
            }

            foreach (KeyValuePair<string, string> kvp in machine)
            {
                Console.WriteLine("{0} {1}",
                                  kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
