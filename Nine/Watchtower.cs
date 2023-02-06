namespace Nine;

public class Watchtower
{
    public void Start()
    {
        int x = Helper.GetValidNumberInRange(-1, 1, "Enter x");
        int y = Helper.GetValidNumberInRange(-1, 1, "Enter Y");

        if (x is 0 && y is 0)
        {
            Console.WriteLine("Enemy is here");
        }
        else
        {
            string location = GetLocation(x, y);
            Console.WriteLine($"Enemy is to the {location}");
        }
    }

    private string GetLocation(int x, int y)
    {
        string phrase = string.Empty;

        switch (x)
        {
            case 1 when y == 1:
                phrase += "northwest";
                break;
            case 1 when y == 0:
                phrase += "west";
                break;
            case 1 when  y == -1:
                phrase += "southwest";
                break;
            
            case 0 when y == 1:
                phrase += "north";
                break;
            case 0 when y == -1:
                phrase += "south";
                break;
            
            
            case -1 when y == 1:
                phrase += "northeast";
                break;
            case -1 when y == 0:
                phrase += "east";
                break;
            case -1 when  y == -1:
                phrase += "southeast";
                break;
            
        }

        return phrase;
    }
}