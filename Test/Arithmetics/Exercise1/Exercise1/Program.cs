using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 0;

            Console.WriteLine("Enter first integers: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integers: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            Console.WriteLine(valueCheck.Check());

            Console.ReadKey();
        }
    }
}
