namespace TwentyFour;

public class Color
{
    public int Red { get; private set; }
    public int Green { get; private set; }
    public int Blue { get; private set; }


    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public static Color White() => new Color(255, 255, 255);
    public static Color Black() => new Color(0, 0, 0);
    public static Color Redd() => new Color(255, 0, 0);
    public static Color Orange() => new Color(255,165, 0);
    public static Color Yellow() => new Color(55, 255, 0);
    public static Color Greenn() => new Color(0, 128, 0);
    public static Color Bluee() => new Color(0, 0, 255);
    public static Color Purple() => new Color(128, 0, 128);


    public override string ToString() => $"({Red}, {Green}, {Blue})";
}