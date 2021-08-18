using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            var date = new Date(day, month, year);
            date.DisplayDate();
            Console.ReadKey();
        }
    }
}
