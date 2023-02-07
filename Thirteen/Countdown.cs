namespace Thirteen;

public class Countdown
{
    public void Start()
    {
        CountIt(10);
    }

    public void CountIt(int i)
    {
        if (i == 0)
        {
            Console.WriteLine("Blast off");
            return;
        }

        Console.WriteLine(i);
        CountIt(i-1);
    }
}