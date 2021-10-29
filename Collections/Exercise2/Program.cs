using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("White");
            mySet.Add("Brown");
            mySet.Add("Blue");

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet));
            Console.WriteLine();

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Is mySet empty: ");
            mySet.Clear();
            Console.WriteLine(mySet.Count == 0);
            Console.WriteLine();

            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));
            Console.ReadKey();
        }
    }
}
