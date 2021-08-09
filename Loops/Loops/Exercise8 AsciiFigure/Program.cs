using System;

namespace Exercise8_AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int length = 0;
            int plusEight = 0;
            int count = 1;

            if (number > 1)
            {
                while (count != number)
                {
                    length += 8;
                    count ++;
                }
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < length / 2; j++)
                    {
                        Console.Write("/");
                    }
                    for (int j = 0; j < plusEight; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < length / 2; j++)
                    {
                        Console.Write("\\");
                    }
                    Console.WriteLine();
                    length -= 8;
                    plusEight += 8;
                }
            }
            else
            {
            Console.WriteLine("****");
            }
            Console.ReadKey();
        }
    }
}
