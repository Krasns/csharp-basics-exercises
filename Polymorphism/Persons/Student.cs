using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : Person
    {
        private double _gpa { get; set; }
        public Student(string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
        }
        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }
        public new void Display()
        {
            Console.WriteLine("Student");
            base.Display();
            Console.WriteLine($"\nStudents gpa: {_gpa}");
        }
    }
}
