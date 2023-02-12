// See https://aka.ms/new-console-template for more information

using Eighteen;

var arrow = new  Arrow(ArrowHead.Obsidian, Fletching.Plastic, 15);

var arrow2 = Arrow.CreateEliteArrow();

Console.WriteLine($"cost is {arrow2.GetArrowCost():C}");