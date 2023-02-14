namespace TwentyEight;

public struct Coordinate
{
    public int Row { get; }
    public int Col { get; }

    public Coordinate(int row, int col)
    {
        Row = row;
        Col = col;
    }
}

public class CoordinateTest
{
    public void Start()
    {
        var one = new Coordinate(1, 2);
        var two = new Coordinate(1, 3);

        Console.WriteLine(Adjacent(one,two) ? "adjacent" : "Not adjacent");
        var three = new Coordinate(1, 2);
        var four = new Coordinate(1, 2);
    }


    private bool Adjacent(Coordinate coordinate, Coordinate coordinate2)
    {
        return Math.Abs(coordinate.Col - coordinate2.Col) == 1 || Math.Abs(coordinate.Row - coordinate2.Row) == 1;
    }
}