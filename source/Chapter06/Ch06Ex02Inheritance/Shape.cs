using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02Inheritance
{
    internal abstract class Shape
    {
        protected double _height;
        protected double _width;

        public virtual double Height
        {
            get => _height;
            init => _height = value;
        }

        public virtual double Width
        {
            get => _width;
            init => _width = value;
        }
        public abstract double Area { get; }
    }
}
