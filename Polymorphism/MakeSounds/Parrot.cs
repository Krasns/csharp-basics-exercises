using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Parrot : Firework
    {
        private List<string> parrot;

        public Parrot()
        {
            parrot = new List<string>();
        }
        public void AddColor(string color)
        {
            parrot.Add(color);
        }
        public void Display()
        {
            foreach (var item in parrot)
            {
                Console.WriteLine($"{item}");
                base.PlaySound();
            }
        }
    }
}
