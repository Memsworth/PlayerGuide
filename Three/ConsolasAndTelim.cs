namespace Three;

public class ConsolasAndTelim
{
    public void Start()
    {
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is this bread for?");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.WriteLine($"Noted: {input} got the bread.");
    }
}