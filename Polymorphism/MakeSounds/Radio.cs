using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Radio : Firework
    {
        private List<string> radio;

        public Radio()
        {
            radio = new List<string>();
        }
        public void AddRadio(string brand)
        {
            radio.Add(brand);
        }
        public void Display()
        {
            foreach (var item in radio)
            {
                Console.WriteLine($"{item}");
                base.PlaySound();
            }
        }
    }
}
