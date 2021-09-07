using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int numberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + numberedSurveyed);
            Console.WriteLine("Approximately " + CalculateEnergyDrinkers(numberedSurveyed) + " bought at least one energy drink");
            Console.WriteLine(CalculatePreferCitrus(numberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(int numberSurveyed)
        {
            return numberSurveyed * PreferCitrusDrinks;
        }
    }
}
