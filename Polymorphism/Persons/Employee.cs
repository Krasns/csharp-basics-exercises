using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle { get; set; }
        public Employee(string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
        }
        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }
        public new void Display()
        {
            Console.WriteLine("Employee");
            base.Display();
            Console.WriteLine($"\nEmployees job title: {_jobTitle}");
        }
    }
}
