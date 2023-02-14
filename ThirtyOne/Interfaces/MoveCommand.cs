using ThirtyOne.Enumerations;

namespace ThirtyOne.Interfaces;

public class MoveCommand : ICommand
{
    public Directions Direction { get; }

    public MoveCommand(Directions direction)
    {
        Direction = direction;
    }

    public void Execute(FountOfObjects game)
    {
        var currentLocation = game.Player.PlayerLocation;
        Location newLocation = Direction switch
        {
            Directions.North => new Location(currentLocation.X, currentLocation.Y - 1),
            Directions.East => new Location(currentLocation.X + 1, currentLocation.Y),
            Directions.South => new Location(currentLocation.X, currentLocation.Y + 1),
            Directions.West => new Location(currentLocation.X - 1, currentLocation.Y),
            _ => throw new ArgumentOutOfRangeException()
        };

        if (game.CheckMap(newLocation))
        {
            game.Player.SetNewPlayerLocation(newLocation);
        }
        else
        {
            Console.WriteLine($"Wall in your way");
        }
    }
}