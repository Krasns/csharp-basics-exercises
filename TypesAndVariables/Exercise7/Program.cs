using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            char[] Arrayname;
            int Count;

            Console.Write("Enter a string: ");
            Name = Console.ReadLine();
            Arrayname = Name.ToCharArray();
            Count = 0;

            foreach (char Letter in Arrayname)
            {
                if (char.IsUpper(Letter))
                    Count++;
            }

            Console.WriteLine($"There is {Count} upper letters.");
            Console.ReadKey();
        }
    }
}
