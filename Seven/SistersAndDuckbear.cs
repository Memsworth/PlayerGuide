namespace Seven;

public class SistersAndDuckbear
{
    public void Start()
    {
        var eggs = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter how many eggs");
        Console.WriteLine($"Each sister should get {(int)(eggs/4)}");
        Console.WriteLine($"Duckbear would get {eggs%4}");
    }
}