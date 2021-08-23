using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine("First element: " + colors.ElementAt(0));
            
            Console.WriteLine("Third element: " + colors.ElementAt(2));
            Console.ReadLine();
        }
    }
}
