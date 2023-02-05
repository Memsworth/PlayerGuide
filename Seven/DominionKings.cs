namespace Seven;

public class DominionKings
{
    public void Start()
    {
        var estate = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter the estates you have");
        var duchy = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter the duchies you have");
        var province = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter the provinces you have");

        var points = Calculate(estate, duchy, province);
        Console.WriteLine($"You have {points} points");
    }

    public int Calculate(int estateInput, int duchyInput, int provinceInput)
    {
        const int estate = 1;
        const int duchy = 3;
        const int province = 6;

        return (estateInput * estate) + (duchy * duchyInput) + (province * provinceInput);
    }
}