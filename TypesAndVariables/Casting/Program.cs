﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int sum = Convert.ToInt32(int.Parse(a) + b + c + d + e);
            Console.WriteLine(sum);
        }

        static void Second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            int.Parse(a);

            float sum = int.Parse(a) + b + c + (float)d + e;
            Console.WriteLine(sum);
        }
    }
}