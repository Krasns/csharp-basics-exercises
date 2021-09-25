using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            double sum = Math.PI* Math.Pow(Convert.ToDouble(radius), 2);
            return Math.Round(sum,2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            decimal sum = length * width;
            return Convert.ToDouble(Math.Round(sum, 2));
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            double sum = Convert.ToDouble(ground) * Convert.ToDouble(h) * 0.5;
            return Math.Round(sum, 2);
        }
    }
}
