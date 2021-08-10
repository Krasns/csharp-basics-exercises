using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            long minutes, year, remainingMinutes, day;

            Console.WriteLine("Biggest number is 9223372036854775807.");
            Console.Write("Enter the number of minutes: ");
            minutes = Convert.ToInt64(Console.ReadLine());

            year = minutes / 525600;
            remainingMinutes = minutes % 525600;
            day = remainingMinutes / 1440;

            Console.WriteLine($"{minutes} minutes is {year} years and {day} days.");
            Console.ReadKey();
        }
    }
}
