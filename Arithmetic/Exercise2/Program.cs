using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;

            Console.Write("Enter a number: ");
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
                Console.WriteLine("Odd Number");

            Console.WriteLine("bye!");
            Console.ReadKey();
        }
    }
}
