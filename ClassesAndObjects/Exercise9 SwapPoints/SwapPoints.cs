using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_SwapPoints
{
    class SwapPoints
    {
        public int X;
        public int Y;
        public SwapPoints(int x , int y)
        {
            X = x;
            Y = y;
        }
        public void PointSwap(SwapPoints p1, SwapPoints p2)
        {
            int x = p1.X;
            int y = p1.Y;

            p1.X = p2.X;
            p1.Y = p2.Y;

            p2.X = x;
            p2.Y = y;
        }
    }
}
