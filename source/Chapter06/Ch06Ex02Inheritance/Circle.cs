using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02Inheritance
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            _height = radius;
            _width = radius;
        }

        public override double Area => Math.PI * _height * _width;
    }
}
