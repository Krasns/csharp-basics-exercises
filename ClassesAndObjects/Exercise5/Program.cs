using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day:");
            string day = Console.ReadLine();

            Console.WriteLine("Enter month:");
            string month = Console.ReadLine();

            Console.WriteLine("Enter year:");
            string year = Console.ReadLine();

            var date = new Date(day, month, year);
            date.DisplayDate();
            Console.ReadKey();
        }
    }
}
