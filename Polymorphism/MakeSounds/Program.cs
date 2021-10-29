using System;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var radioBrand = new Radio();
            radioBrand.AddRadio("Samsung");
            radioBrand.AddRadio("Sony");
            radioBrand.AddRadio("LG");
            radioBrand.Display();
            Console.WriteLine();

            var parrot = new Parrot();
            parrot.AddColor("Black");
            parrot.AddColor("White");
            parrot.AddColor("Red");
            parrot.Display();

            Console.ReadKey();
        }
    }
}