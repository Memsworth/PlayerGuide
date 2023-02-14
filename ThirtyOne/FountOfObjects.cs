using ThirtyOne.Entities;
using ThirtyOne.Enumerations;
using ThirtyOne.Interfaces;
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
        GameMap.SetTerrain(new Location(Fountain.FountainLocation.Row, Fountain.FountainLocation.Col), RoomType.Fountain);

        do
        {
            displayEngine.DisplayGame(this);
            var currentCommand = GetCurrentCommand();
            currentCommand.Execute(this);

            if ((Player.PlayerLocation.Row == 0 && Player.PlayerLocation.Col == 0) && Fountain.Activation == true)
            {
                break;
            }
        } while (true);
        
    }

    private ICommand GetCurrentCommand()
    {
        return Console.ReadLine() switch
        {
            "activate" => new FountainCommand(),
            "move north" => new MoveCommand(Directions.North),
            "move south" => new MoveCommand(Directions.South),
            "move west" => new MoveCommand(Directions.West),
            "move east" => new MoveCommand(Directions.East),
            _ => throw new ArgumentOutOfRangeException()
        };
    }


    public bool IsOutOfBound(Location location)
    {
        return location.Row >= 0 && location.Row < GameMap.GameGrid.GetLength(0) && location.Col >= 0 &&
               location.Col < GameMap.GameGrid.GetLength(1);
    }
}