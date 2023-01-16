namespace Ch06Ex02Inheritance;

internal class Circle : Shape
{
    public Circle(double radius)
    {
        _height = radius;
        _width = radius;
    }

    public override double Area => Math.PI * _height * _width;
}