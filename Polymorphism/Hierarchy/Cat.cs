using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Cat : Felime
    {
        public string _breed;
        public Cat()
        {
        }
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
        {
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _livingRegion = livingRegion;
            _breed = breed;
        }
        public new void Eat(Food food)
        {
            food._quantity = _foodEaten;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mew Mew");
        }
    }
}
