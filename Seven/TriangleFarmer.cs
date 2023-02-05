namespace Seven;

public class TriangleFarmer
{
    public void Start()
    {
        var baseInput = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter base");
        var height = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter height");
        Console.WriteLine($"With a base of {baseInput} & height of {height}, the area is: {(baseInput*height)/2:N}");
    }
}