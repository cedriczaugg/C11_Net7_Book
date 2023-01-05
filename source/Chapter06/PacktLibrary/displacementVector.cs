namespace Packt.Shared;

public struct displacementVector
{
    public int X { get; set; }
    public int Y { get; set; }

    public displacementVector(int initialX, int initialY)
    {
        X = initialX;
        Y = initialY;
    }

    public static displacementVector operator +(displacementVector left, displacementVector right)
    {
        return new displacementVector(left.X + right.X, left.Y + right.Y);
    }
}