namespace Eleven;

public class Prototype
{
    public void Start()
    {
        int input = Helper.GetValidNumberInRange(1, 99, "User 1, enter a number between 0-100");

        Console.Clear();
        Console.WriteLine("user 2, guess the number");
        while (true)
        {
            int user2Input = Helper.GetValidNumberInRange(1, 99, "What is your next guess");
            
            if (user2Input == input)
            {
                Console.WriteLine("Bulls EYE");
                break;
            }

            Console.WriteLine(user2Input > input ? $"{user2Input} is too high." : $"{user2Input} is low high.");
        }
    }
}