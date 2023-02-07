using System.Threading.Channels;

namespace Ten;

public class Inventory
{
    public void Start()
    {
        int totalCost = 0;
        while (true)
        {
            if (GetMenuChoice() is 0) break;
            
            Console.Clear();
            
            ShowMenu();

            int item = GetItemChoice();
            int currentCost = GetItemCost(item);

            totalCost += currentCost;
        }

        Console.WriteLine($"Total payment to do: {totalCost} gold");
    }

    private void ShowMenu()
    {
        Console.WriteLine("The following items are available:\n" +
                          "1 – Rope\n" +
                          "2 – Torches\n" +
                          "3 – Climbing Equipment\n" +
                          "4 – Clean Water\n" +
                          "5 – Machete\n" +
                          "6 – Canoe\n" +
                          "7 – Food Supplies");
    }



    private string GetNameInput()
    {
        Console.Write("Who referred ya? ");
        return Console.ReadLine() ?? throw new ArgumentNullException();
    }
    private int GetMenuChoice() => Helper.GetValidNumberInRange(0, 1, "1 to add an item. 0 to exit");
    private int GetItemChoice() => Helper.GetValidNumberInRange(1, 7, "What number do you want to see the price of");
    
    private int GetItemCost(int choice)
    {
        string name = "Ahmed";
        string itemName = string.Empty;
        int cost = 0;
        
        switch (choice)
        {
            case 1:
                cost = 10;
                itemName = "Rope";
                break;
            case 2:
                cost = 16;
                itemName = "Torches";
                break;
            case 3: 
                cost = 24; 
                itemName = "Climbing Equipment";
                break;
            case 4:
                cost = 2;
                itemName = "Clean Water";
                break;
            case 5:
                cost = 20;
                itemName = "Machete";
                break;
            case 6: 
                cost = 200;
                itemName = "Canoe";
                break;
            case 7:
                cost = 2;
                itemName = "Food Supplies";
                break;
        }

        var nameInput = GetNameInput();
        if (nameInput == name) cost /= 2;
        DisplayCost(itemName, cost);
        return cost;
    }

    private void DisplayCost(string itemName, int cost)
    {
        Console.WriteLine($"{itemName} cost {cost} gold");
    }
}