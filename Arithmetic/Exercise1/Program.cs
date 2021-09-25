using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber,sum, firstDiff, secondDiff;

            Console.WriteLine("Enter first integers: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integers: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            sum = firstNumber + secondNumber;
            firstDiff = firstNumber - secondNumber;
            secondDiff = secondNumber - firstNumber;

            if (firstNumber == 15 || secondNumber == 15 || sum == 15 || firstDiff == 15 || secondDiff == 15)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            
            Console.ReadKey();
        }
    }
}
