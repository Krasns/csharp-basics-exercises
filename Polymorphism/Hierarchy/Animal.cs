using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    abstract class Animal
    {
        public string _animalName { get; set; }
        public string _animalType { get; set; }
        public double _animalWeight { get; set; }
        public int _foodEaten { get; set; }
        public abstract void MakeSound();
        public void Eat(Food food)
        {
            food._quantity = _foodEaten;
        }
    }
}
