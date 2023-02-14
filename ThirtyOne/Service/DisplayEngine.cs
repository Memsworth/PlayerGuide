using ThirtyOne.Entities;

namespace ThirtyOne.Service;

public class DisplayEngine
{
    public void DisplayGame(FountOfObjects fountOfObjects)
    {
        Console.WriteLine("----------------------------------------------------------------------------------");
        DisplayPlayerLocation(fountOfObjects.Player);
    }

    private void DisplayPlayerLocation(Player player)
    {
        Console.WriteLine($"You are in the room at (Row={player.PlayerLocation.Row}, Column={player.PlayerLocation.Col}).");
        Console.WriteLine("What you wanna do");
    }
}