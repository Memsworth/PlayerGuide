namespace Fourteen;

public class HuntingManticore
{
    public void Start()
    {
        var item = Helper.GetValidNumberInRange(1, 99, "player 1 enter");

        var cityHealth = 15;
        var mantiCoreHealth = 10;
        var round = 1;
        Console.Clear();

        while (cityHealth > 0 && mantiCoreHealth > 0)
        {

            DisplayUi(round, cityHealth, mantiCoreHealth);
            var itemsss = Helper.GetValidNumberInRange(1, 100, "Enter desired cannon range");

            if (itemsss == item)
            {
                DisplayShotResult(0);
                mantiCoreHealth -= GetDamage(round);
            }
            else if (itemsss > item)
            {
                DisplayShotResult(1);
            }
            else
            {
                DisplayShotResult(-1);
            }

            round++;
            cityHealth--;
        }

        Console.WriteLine(mantiCoreHealth > 0 ? $"Manitcore won" : "City won");
    }


    private void DisplayUi(int round, int cityHealth, int mantiCoreHealth)
    {
        StatusDisplay(round, cityHealth, mantiCoreHealth);
        DisplayDamageStatus(round);
    }
    
    private void StatusDisplay(int round, int cityHealth, int mantiCoreHealth)
    {
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {mantiCoreHealth}/10");
        

        
    }


    public void DisplayDamageStatus(int round)
    {
        Console.Write($"The cannon is expected to deal");
        
        Console.ForegroundColor = (GetDamage(round)) switch
        {
            10 => ConsoleColor.Blue,
            3 => ConsoleColor.Yellow,
            _ => ConsoleColor.Gray
        };
        
        Console.Write($" {GetDamage(round)} ");
        Console.ResetColor();
        Console.WriteLine("damage this round.");

    }

    private void DisplayShotResult(int i)
    {
        switch (i)
        {
            case 1:
                Console.WriteLine("That round OVERSHOT the target.");
                break;
            case -1:
                Console.WriteLine("That round FELL SHORT of the target.");
                break;
            case 0:
                Console.WriteLine("That round was a DIRECT HIT!");
                break;
        }
    }

    private int GetDamage(int i)
    {
        if (i % 15 == 0) return 10;
        if (i % 3 == 0 || i % 5 == 0) return 3;
        return 1;
    }
}