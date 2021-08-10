using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] number = new int [20];

            Console.Write("Witch of 20 random numbers would you like to knew: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                number[i] = rand.Next(0, 100);
                
                if (input-1 == i)
                {
                    Console.WriteLine(number[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
