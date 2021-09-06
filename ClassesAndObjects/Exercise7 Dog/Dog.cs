using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_Dog
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }
        public Dog(string name, string sex, string mother, string father) : this (name,sex)
        {
            _mother = mother;
            _father = father;
        }
        public string FathersName()
        {
            return _father != null ? _father : "Unknown";
        } 
        public bool HasSameMotherAs(Dog otherDog)
        {
            return otherDog._mother == _mother ? true : false;
        }
    }
}
