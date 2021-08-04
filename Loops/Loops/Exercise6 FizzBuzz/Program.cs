using System;

namespace Exercise6_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max value?");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < max; i++)
            {
                if ((i-1) % 20 == 0)
                {
                    Console.WriteLine();
                }

                if (i%15==0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i%3==0)
                {
                    Console.Write("Fizz ");
                }
                else if (i%5==0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
