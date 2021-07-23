using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber,Sum, FirstDiff, SecondDiff;

            Console.WriteLine("Enter first integers: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integers: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            Sum = FirstNumber + SecondNumber;
            FirstDiff = FirstNumber - SecondNumber;
            SecondDiff = SecondNumber - FirstNumber;

            if (FirstNumber == 15 || SecondNumber == 15 || Sum == 15 || FirstDiff == 15 || SecondDiff == 15)
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
