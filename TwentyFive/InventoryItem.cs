using System.Collections;

namespace TwentyFive;

public class PackTest
{
    public void Start()
    {
        var backPack = new Pack(20, 50, 50);
        var display = new DisplayEngine();

        while (true)
        {
            Console.WriteLine("0. Exit, 1. Add item, 2. List items");
            var choice = Helper.GetValidNumberInRange(0, 1, "Enter your choice");

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine(backPack);
                    Console.WriteLine(backPack.Add(GetItem()) ? "" : "Can't add item");
                    display.DisplayCurrentStatus(backPack);
                    break;
                case 2:
                    break;
            }
        }
    }
    
    private InventoryItem GetItem()
    {
        Console.WriteLine("1.Arrow, 2.Bow, 3.Rope, 4.Water, 5.FoodRation, 6.Sword");
        int choice = Helper.GetValidNumberInRange(1, 6, "Enter a your item");

        return choice switch
        {
            1 => new Arrow(),
            2 => new Bow(),
            3 => new Rope(),
            4 => new Water(),
            5 => new FoodRations(),
            6 => new Sword(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public class DisplayEngine
{
    public void DisplayCurrentStatus(Pack pack)
    {
        Console.WriteLine(
            $"Current capacity: {GetCurrentCount(pack.PackItems)}/{pack.MaxCapacity}\t" +
            $"Volume: {GetCurrentVolume(pack.PackItems)}/{pack.MaxVolume}\t " +
            $"Weight: {GetCurrentWeight(pack.PackItems)}/{pack.MaxWeight}");
    }

    private static int GetCurrentCount(ICollection items) => items.Count;
    private static double GetCurrentWeight(IEnumerable<InventoryItem> items) => items.Sum(item => item.Weight);
    private static double GetCurrentVolume(IEnumerable<InventoryItem> items) => items.Sum(item => item.Volume);
}

public class Pack
{
    public List<InventoryItem> PackItems { get; }
    public int MaxCapacity { get; }
    public double MaxVolume { get; }
    public double MaxWeight { get; }

    public Pack(int itemCount,  double maxVolume, double maxWeight)
    {
        PackItems = new List<InventoryItem>();
        MaxCapacity = itemCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;
    }

    public bool Add(InventoryItem item)
    {
        if (CheckWeight(item)) return false;
        if (CheckVolume(item)) return false;
        if (CheckSpace()) return false;

        PackItems.Add(item);

        return true;
    }

    private bool CheckSpace() => PackItems.Count + 1 > MaxCapacity;
    private bool CheckWeight(InventoryItem inventoryItem)
    {
        double weight = 0;
        
        weight += PackItems.Sum(item => item.Weight);

        return weight + inventoryItem.Weight > MaxWeight;
    }
    
    private bool CheckVolume(InventoryItem inventoryItem)
    {
        double volume = 0;
        volume += PackItems.Sum(item => item.Volume);
        
        return volume + inventoryItem.Volume > MaxVolume;
    }

    public override string ToString() =>
        PackItems.Aggregate("Pack containing:", (current, item) => current + $" {item.ToString()}");

}


public class InventoryItem
{
    public double Weight { get; private set; }
    public double Volume { get; private set; }

    protected InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem
{
    public Arrow(double weight, double volume) : base(weight, volume)
    { }

    public Arrow() : base(0.1, 0.05)
    { }

    public override string ToString() => "Arrow";
}

public class Bow : InventoryItem
{
    public Bow(double weight, double volume) : base(weight, volume)
    { }

    public Bow() : base(1, 4)
    { }
    
    public override string ToString() => "Bow";
}

public class Rope : InventoryItem
{
    public Rope(double weight, double volume) : base(weight, volume)
    { }

    public Rope() : base(1, 1.5)
    { }
    
    public override string ToString() => "Rope";
}

public class Water : InventoryItem
{
    public Water(double weight, double volume) : base(weight, volume)
    { }

    public Water() : base(2, 3)
    { }
    public override string ToString() => "Water";
}

public class FoodRations : InventoryItem
{
    public FoodRations(double weight, double volume) : base(weight, volume)
    { }

    public FoodRations() : base(1, 0.5)
    { }
    public override string ToString() => "Food Ration";
}

public class Sword : InventoryItem
{
    public Sword(double weight, double volume) : base(weight, volume)
    { }

    public Sword() : base(5, 3)
    { }
    public override string ToString() => "Sword";
}