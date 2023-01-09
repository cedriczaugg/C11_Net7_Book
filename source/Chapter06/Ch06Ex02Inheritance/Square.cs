using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02Inheritance
{
    internal class Square : Shape
    {
        public Square(double side)
        {
            this._height = side;
            this._width = side;
        }

        public override double Area => _height * _width;
    }
}
