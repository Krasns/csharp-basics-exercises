using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Person
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _address { get; set; }
        private int _id { get; set; }
        public Person()
        {
        }
        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }
        public void Display()
        {
            Console.Write($"First name: {_firstName}\nLast name: {_lastName}\nAddress: {_address}\nId: {_id}"); 
        }
        
    }
}
