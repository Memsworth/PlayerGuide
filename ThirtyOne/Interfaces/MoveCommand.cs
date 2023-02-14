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
            Directions.North => new Location(currentLocation.Row, currentLocation.Col - 1),
            Directions.East => new Location(currentLocation.Row + 1, currentLocation.Col),
            Directions.South => new Location(currentLocation.Row, currentLocation.Col + 1),
            Directions.West => new Location(currentLocation.Row - 1, currentLocation.Col),
            _ => throw new ArgumentOutOfRangeException()
        };

        if (game.IsOutOfBound(newLocation))
        {
            game.Player.SetNewPlayerLocation(newLocation);
        }
        else
        {
            Console.WriteLine($"Wall in your way");
        }
    }
}