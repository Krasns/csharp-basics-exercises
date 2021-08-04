using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min?");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Max?");
            int max = Convert.ToInt32(Console.ReadLine());

            int number = min;

            for (int i = 0; i <= max - min; i++)
            {
                Console.WriteLine();
                if (number != number + i)
                {
                number = min + i;
                }
                for (int j = 0; j <= max - min; j++)
                {
                    if (number > max)
                    {
                        number = min;
                    }
                Console.Write(number);
                number++;
                }
            }
        }
    }
}
