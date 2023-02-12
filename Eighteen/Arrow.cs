using System.Diagnostics;

namespace Eighteen;

public class Arrow
{
    public ArrowHead ArrowHeadType { get; private set; }
    public Fletching FletchingType { get; private set; }
    public int Length { get; private set; }


    public Arrow(ArrowHead arrowHeadType, Fletching fletchingType, int length)
    {
        ArrowHeadType = arrowHeadType;
        FletchingType = fletchingType;
        Length = length;
    }

    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65);
    
    public double GetArrowCost() => GetLengthCost() + GetFletchCost() + GetArrowHeadCost();

    private double GetLengthCost() => Length * 0.05;

    private double GetArrowHeadCost()
    {
        return ArrowHeadType switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5
        };
    }

    private double GetFletchCost()
    {
        return FletchingType switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };
    }
}


public enum ArrowHead
{
    Steel, Wood, Obsidian
}

public enum Fletching
{
    Plastic, TurkeyFeathers, GooseFeathers
}