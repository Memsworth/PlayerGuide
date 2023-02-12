namespace TwentyFour;

public class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0)
    {
        
    }
    public override string ToString() => $"({X}, {Y})";
}