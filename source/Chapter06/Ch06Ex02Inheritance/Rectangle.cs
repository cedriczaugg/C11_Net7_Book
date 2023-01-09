using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02Inheritance
{
    internal class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }

        public override double Area => _height * _width;
    }
}
