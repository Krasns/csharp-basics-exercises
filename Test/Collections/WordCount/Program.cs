using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = File.ReadAllLines(@"D:\Codelex Lekcijas\csharp-basics-exercises\Collections\WordCount\text.txt").Length;

            string text = File.ReadAllText(@"D:\Codelex Lekcijas\csharp-basics-exercises\Collections\WordCount\text.txt");
            string[] textArray = text.Split(' ');
            int countWords = textArray.Length;
            
            int countChar = File.ReadAllText(@"D:\Codelex Lekcijas\csharp-basics-exercises\Collections\WordCount\text.txt").Length;

            Console.WriteLine($"Lines: {countLines}");
            Console.WriteLine($"Words: {countWords}");
            Console.WriteLine($"Chars: {countChar}");
            Console.ReadLine();
        }
    }
}
