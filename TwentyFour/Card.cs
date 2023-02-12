namespace TwentyFour;

public class CardTest
{
    public void Start()
    {
        var deck = (from color in Enum.GetValues<Colors>()
            from symbol in Enum.GetValues<Symbols>()
            select new Card(color, symbol)).ToList();

        var displayEngine = new CardHelper();
        
        displayEngine.DisplayCards(deck);
    }
    
    
}
public class Card
{
    public Colors ColorType { get; private set; }
    public Symbols SymbolType { get; private set; }

    public Card(Colors color, Symbols symbol)
    {
        ColorType = color;
        SymbolType = symbol;
    }
}

public enum Colors
{
    Red, Green, Blue, Yellow
};

public enum Symbols
{
    One , Two , Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Ampersand, Power
};

public class CardHelper
{
    public void DisplayCards(List<Card> deck)
    {
        var count = 0;
        foreach (var card in deck)
        {
            if (count % 4 == 0)
                Console.WriteLine("");
            
            Console.Write($"The {GetColor(card.ColorType)} {GetRank(card.SymbolType)}\t");
            count++;
        }
    }

    private string GetColor(Colors color)
    {
        return color switch
        {
            Colors.Red => Colors.Red.ToString(),
            Colors.Green => Colors.Green.ToString(),
            Colors.Blue => Colors.Blue.ToString(),
            Colors.Yellow => Colors.Yellow.ToString(),
            _ => throw new ArgumentOutOfRangeException(nameof(color), color, null)
        };
    }
    
    
    private string GetRank(Symbols symbols)
    {
        return symbols switch
        {
            Symbols.One => Symbols.One.ToString(), 
            Symbols.Two => Symbols.Two.ToString(), 
            Symbols.Three => Symbols.Three.ToString(), 
            Symbols.Four => Symbols.Four.ToString(), 
            Symbols.Five => Symbols.Five.ToString(), 
            Symbols.Six => Symbols.Six.ToString(), 
            Symbols.Seven => Symbols.Seven.ToString(), 
            Symbols.Eight => Symbols.Eight.ToString(), 
            Symbols.Nine => Symbols.Nine.ToString(), 
            Symbols.Ten => Symbols.Ten.ToString(), 
            Symbols.DollarSign => Symbols.DollarSign.ToString(), 
            Symbols.Percent => Symbols.Percent.ToString(), 
            Symbols.Ampersand => Symbols.Ampersand.ToString(), 
            Symbols.Power => Symbols.Power.ToString(),
            _ => throw new ArgumentOutOfRangeException(nameof(symbols), symbols, null)
        };
    }
}