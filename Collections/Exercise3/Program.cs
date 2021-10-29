using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new HashSet<string>();

            int count = 0;
            while (count != 5)
            {
                Console.Write("Enter name: ");
                string input = Console.ReadLine();
                name.Add(input);
                count++;
            }
            Console.WriteLine("Unique name list contains: " + string.Join(" ",name));
            Console.ReadKey();
        }
    }
}
