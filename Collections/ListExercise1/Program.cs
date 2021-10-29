using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Mint");
            colors.Add("Green");
            colors.Add("Yellow");

            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
