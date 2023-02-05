
namespace Eight;

public class DefenseOfConsolas
{
    public void Start()
    {
        var row = Helper.GetValidNumberInRange(1, 8, "Target Row");
        var col = Helper.GetValidNumberInRange(1, 8, "Target Column");


        Console.WriteLine($"Deploy to ({row}, {col-1})");
        Console.WriteLine($"Deploy to ({row-1}, {col})");
        Console.WriteLine($"Deploy to ({row}, {col+1})");
        Console.WriteLine($"Deploy to ({row+1}, {col})");
        
        Console.Beep(440, 1000);
    }
}