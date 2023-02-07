namespace Twelve;

public class Replicator
{
    public void Start()
    {
        var len = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter the length you want to create");

        var items = new int[len];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = GetInput(i);
        }

        DisplayItems(items);

        var items2 = new int[items.Length];
        
        items.CopyTo(items2, 0);
        
        DisplayItems(items2);
    }

    private int GetInput(int i) => Helper.GetValidNumberInRange(int.MinValue, int.MaxValue, $"Enter for space {i + 1}");
    private void DisplayItems(int[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i+1}: {items[i]}");
        }
    }
}