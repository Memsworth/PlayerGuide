namespace ThirtyOne.Interfaces;

public class FountainCommand : ICommand
{
    public void Execute(FountOfObjects game)
    {
        if (game.Player.PlayerLocation == game.Fountain.FountainLocation)
        {
            game.Fountain.ActivateFountain();
        }
    }
}