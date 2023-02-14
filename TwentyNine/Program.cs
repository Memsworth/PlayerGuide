// See https://aka.ms/new-console-template for more information

var sword = new Sword(Material.Iron, null, 20, 20);

var swordTwo = sword with { SwordGemstone = Gemstone.BitStone, Length = 50 };

Console.WriteLine(sword);
Console.WriteLine(swordTwo);

public enum Material
{
    Wood, Bronze, Iron, Steel, Binarium
}

public enum Gemstone
{
    Emerald, Amber, Sapphire, Diamond, BitStone
}

public record Sword(Material SwordMaterial, Gemstone? SwordGemstone, int Length, int Width);