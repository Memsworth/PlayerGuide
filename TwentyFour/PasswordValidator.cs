namespace TwentyFour;


public class PasswordValidatorTest
{
    public void Start()
    {
        var validator = new PasswordValidator();

        while (true)
        {
            Console.Write("Enter a password");
            var input = Console.ReadLine() ?? throw new ArgumentNullException();
            var validity = validator.ValidPassword(input);

            Console.WriteLine(validity ? "Password is valid" : "Password is not valid");
        }
    }
}


public class PasswordValidator
{
    public bool ValidPassword(string input)
    {
        const int min = 6;
        const int max = 13;

        var containsDigit = false;
        var containsUpper = false;
        var containsLower = false;

        if (input.Contains("T") || input.Contains("&") || input.Length is < min or > max)
        {
            return false;
        }

        foreach (var item in input)
        {
            if (char.IsNumber(item))
            {
                containsDigit = true;
            }

            if (char.IsUpper(item))
            {
                containsUpper = true;
            }

            if (char.IsLower(item))
            {
                containsLower = true;
            }
        }
        
        return containsDigit && containsLower && containsUpper;
    }
}