using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Karlis", "Reibais", "Juglas Priedes", 1,25.45);
            var employee = new Employee("Riguns", "Reibonis", "Daugavas Priedes", 1, "Teacher");

            student.Display();
            Console.WriteLine();
            employee.Display();

            Console.ReadLine();
        }
    }
}