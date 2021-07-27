using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int birthYear;

            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter birth year");
            int.TryParse(Console.ReadLine(), out birthYear);

            Console.WriteLine($"My {name} is Juan Valdez and I was born in {birthYear}. ");
            Console.ReadKey();
        }
    }
}
