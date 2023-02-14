namespace ThirtyOne;

public class Location
{
    public int Row { get; }
    public int Col { get; }

    public Location(int x, int y)
    {
        Row = x;
        Col = y;
    }
}