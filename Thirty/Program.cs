// See https://aka.ms/new-console-template for more information

var itemOne = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
var itemTwo = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
var itemThree = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

itemOne.Display();
itemTwo.Display();
itemThree.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public ConsoleColor ItemColor { get; }
    public T Item { get; }

    public ColoredItem(T item, ConsoleColor color)
    {
        ItemColor = color;
        Item = item;
    }

    public void Display()
    {
        Console.ForegroundColor = ItemColor;
        Console.WriteLine(Item?.ToString());
    }
}
