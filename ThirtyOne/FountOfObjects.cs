using ThirtyOne.Entities;
using ThirtyOne.Enumerations;
using ThirtyOne.Service;

namespace ThirtyOne;

public class FountOfObjects
{
    public Map GameMap { get; }
    public Player Player { get; }
    public Fountain Fountain { get; }

    public FountOfObjects()
    {
        GameMap = new Map(4, 4);
        Player = new Player(new Location(0,0));
        Fountain = new Fountain(new Location(0,2));
    }

    public void RunGame()
    {
        var displayEngine = new DisplayEngine();
        GameMap.SetTerrain(new Location(0,0), RoomType.Entrance);
        GameMap.SetTerrain(new Location(Fountain.FountainLocation.X, Fountain.FountainLocation.Y), RoomType.Fountain);

        while (true)
        {
            displayEngine.DisplayGame(this);
        }
    }



    //TODO
    public bool CheckMap(Location location)
    {
        return false;
    }
}