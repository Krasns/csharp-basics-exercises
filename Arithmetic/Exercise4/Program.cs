using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Sum;

            Console.WriteLine("Enter number: ");
            Number = Convert.ToInt32(Console.ReadLine());
            Sum = 1;

            for (int i = 1; i < Number; i++)
            {
                Sum += Sum * i;
            }

            Console.WriteLine($"Number from 1 to {Number} is {Sum}");
            Console.ReadKey();
        }
    }
}
