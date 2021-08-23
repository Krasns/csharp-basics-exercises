using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int number = input;
            int sum = 0;
            int count = number;
            while (sum != 1)
            {
                sum = 0;
                for (int i = 0; i < count.ToString().Length; i++)
                {
                    var digit = number % 10;
                    number /= 10;
                    sum += digit*digit;
                }
                count = sum;
                number = Convert.ToInt32(sum);
                if (sum == input)
                {
                    Console.WriteLine("Not heppy");
                    sum = 1;
                }
            }
            if (number == 1)
            {
                Console.WriteLine("Heppy");
            }
            Console.ReadKey();
        }
    }
}
