namespace Thirteen;

public class TakingNumber
{
    public void Start()
    {
        var a = AskForNumber("Give me number");
        var b = AskForNumberInRange("Give me number in rage", 1, 10);

        Console.WriteLine($"{a}, {b}");
    }

    private int AskForNumber(string text) => Helper.GetValidNumberInRange(1, int.MaxValue, text);
    private int AskForNumberInRange(string text, int min, int max) => Helper.GetValidNumberInRange(min, max, text);
}