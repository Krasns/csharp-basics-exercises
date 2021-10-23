using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Tiger : Felime
    {
        private string _livingRegion { get; set; }
        public Tiger()
        {
        }
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion)
        {
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _livingRegion = livingRegion;
        }
        public new void Eat(Meat food)
        {
            food._quantity = _foodEaten;
        }

        public override void MakeSound()
        {
            Console.WriteLine("RRROOR");
        }
    }
}
