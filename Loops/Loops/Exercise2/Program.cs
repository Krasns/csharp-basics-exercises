using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0; ;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            sum = n;

            for (i = 0; i < n; i++)
            {
                sum = sum * n;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
