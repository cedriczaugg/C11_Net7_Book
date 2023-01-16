namespace Ch06Ex02Inheritance;

internal class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        _height = height;
        _width = width;
    }

    public override double Area => _height * _width;
}