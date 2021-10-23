using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Mouse : Mammal
    {
        public Mouse()
        {
        }
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion)
        {
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _livingRegion = livingRegion;
        }
        public new void Eat(Vegetable food)
        {
            food._quantity = _foodEaten;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Skree skree");
        }
    }
}
