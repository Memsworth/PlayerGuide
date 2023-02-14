namespace ThirtyOne.Entities;

public class Player
{
    public Location PlayerLocation { get; private set; }

    public Player(Location playerLocation)
    {
        PlayerLocation = playerLocation;
    }

    public void SetNewPlayerLocation(Location location)
    {
        PlayerLocation = location;
    }
}