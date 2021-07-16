using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string First_Class = "English III";
            string Second_Class = "Precalculus";
            string Third_Class = "Music Theory";
            string Fourth_Class = "Biotechnology";
            string Fifth_Class = "Principles of Technology I";
            string Sixth_Class = "Latin II";

            string First_Teacher = "Ms. Lapan";
            string Second_Teacher = "Mrs. Gideon";
            string Third_Teacher = "Mr. Davis";
            string Fourth_Teacher = "Ms. Palmer";
            string Fifth_Teacher = "Ms. Garcia";
            string Sixth_Teacher = "Mrs. Barnett";

            Console.WriteLine("+-------------------------------------------------------+");
            Console.WriteLine($"| 1 | {First_Class} \t\t\t|{First_Teacher}\t|");
            Console.WriteLine($"| 2 | {Second_Class} \t\t\t|{Second_Teacher}\t|");
            Console.WriteLine($"| 3 | {Third_Class} \t\t\t|{Third_Teacher}\t|");
            Console.WriteLine($"| 4 | {Fourth_Class} \t\t\t|{Fourth_Teacher}\t|");
            Console.WriteLine($"| 5 | {Fifth_Class} \t|{Fifth_Teacher}\t|");
            Console.WriteLine($"| 6 | {Sixth_Class} \t\t\t\t|{Sixth_Teacher}\t|");
            Console.WriteLine("+-------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}
