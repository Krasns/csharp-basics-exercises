using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber,Sum, FirstDiff, SecondDiff;

            Console.WriteLine("Enter two integers: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            Sum = FirstNumber + SecondNumber;
            FirstDiff = FirstNumber - SecondNumber;
            SecondDiff = SecondNumber - FirstNumber;

            if (FirstNumber == 15 || SecondNumber == 15)
            {
                Console.WriteLine(true);
            }
            else if (Sum == 15)
            {
                Console.WriteLine(true);
            }
            else if (FirstDiff == 15)
            {
                Console.WriteLine(true);
            }
            else if (SecondDiff == 15)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
