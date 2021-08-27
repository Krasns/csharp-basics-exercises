using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _copys;
        private int _costPerCopy;
        public Poster(int fee) : base(fee)
        {

        }

        public Poster(int fee, int height, int width, int copys, int costPerCopy) :base(fee)
        {
            _height = height;
            _width = width;
            _copys = copys;
            _costPerCopy = costPerCopy;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            fee += _copys * _costPerCopy;
            return fee;
        }

        public override string ToString()
        {
            return $"\nPoster: Cost: {Cost()}";
        }
    }
}
