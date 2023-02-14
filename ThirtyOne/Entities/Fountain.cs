namespace ThirtyOne.Entities;

public class Fountain
{
    public bool Activation { get; private set; }
    public Location FountainLocation { get; }
    public Fountain(Location fountainLocation)
    {
        Activation = false;
        FountainLocation = fountainLocation;
    }

    public void ActivateFountain() => Activation = true;
}