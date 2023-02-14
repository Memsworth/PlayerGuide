using ThirtyOne.Enumerations;

namespace ThirtyOne.Entities;

public class Map
{
    public RoomType[,] GameGrid { get; private set; }
    public int Row { get; }
    public int Col { get; }

    public Map(int row, int col)
    {
        Row = row;
        Col = col;
        GameGrid = new RoomType[row, col];
    }

    public void SetTerrain(Location location, RoomType roomType) => GameGrid[location.Row, location.Col] = roomType;
}