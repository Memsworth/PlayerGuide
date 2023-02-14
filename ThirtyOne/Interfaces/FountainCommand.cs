namespace ThirtyOne.Interfaces;

public class FountainCommand : ICommand
{
    public void Execute(FountOfObjects game)
    {
        if (game.Player.PlayerLocation.Row == game.Fountain.FountainLocation.Row && game.Player.PlayerLocation.Col == game.Fountain.FountainLocation.Col)
        {
            game.Fountain.ActivateFountain();
            Console.WriteLine($"foundtain actived: {game.Fountain.Activation}");
        }
    }
}