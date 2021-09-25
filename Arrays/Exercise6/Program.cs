using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];
            Random r = new Random();

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = r.Next(1, 100);
                secondArray[i] = firstArray[i];
            }

            firstArray[firstArray.Length - 1] = -7;

            Console.Write("Array 1:");
            foreach (var number in firstArray)
            {
                Console.Write($" {number}");
            }

            Console.WriteLine();
            Console.Write("Array 2:");
            foreach (var number in secondArray)
            {
                Console.Write($" {number}");
            }

            Console.ReadKey();
        }
    }
}
