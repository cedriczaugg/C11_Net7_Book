namespace Ch06Ex02Inheritance;

internal class Square : Shape
{
    public Square(double side)
    {
        _height = side;
        _width = side;
    }

    public override double Area => _height * _width;
}