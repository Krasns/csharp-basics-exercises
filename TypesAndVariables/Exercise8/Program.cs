using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            long Minutes, Year, RemainingMinutes, Day;

            Console.WriteLine("Biggest number is 9223372036854775807.");
            Console.Write("Enter the number of minutes: ");
            Minutes = Convert.ToInt64(Console.ReadLine());

            Year = Minutes / 525600;
            RemainingMinutes = Minutes % 525600;
            Day = RemainingMinutes / 1440;

            Console.WriteLine($"{Minutes} minutes is {Year} years and {Day} days.");
            Console.ReadKey();
        }
    }
}
