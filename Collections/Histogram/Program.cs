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
        private const string Path = "../Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(@"D:\Codelex Lekcijas\csharp-basics-exercises\Collections\Histogram\midtermscores.txt");
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
