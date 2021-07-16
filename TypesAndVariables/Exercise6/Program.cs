using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int AddNumber = Convert.ToInt32(Console.ReadLine());
            int SumNumber = 0;

            while (AddNumber !=0)
            {
                SumNumber += AddNumber % 10;
                AddNumber /= 10;
            }
            
            Console.WriteLine(SumNumber);
            Console.ReadKey();
        }
    }
}
