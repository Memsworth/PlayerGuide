namespace Eleven;

public class MagicCannon
{
    public void Start()
    {
        for (int i = 1; i < 101; i++)
        {
            Display(i);
        }
    }



    private void Display(int i)
    {
        var phrase = GetX(i);
        Console.Write($"{i}: ");

        Console.ForegroundColor = phrase switch
        {
            "Blue" => ConsoleColor.Blue,
            "Electric" => ConsoleColor.Yellow,
            "Fire" => ConsoleColor.Red,
            _ => ConsoleColor.Gray
        };

        Console.WriteLine($"{phrase}");
        Console.ResetColor();
        
    }


    private string GetX(int i)
    {
        if (i % 15 == 0) return "Blue";
        if (i % 5 == 0) return "Electric";
        if (i % 3 == 0) return "Fire";
        return "Normal";
    }
}