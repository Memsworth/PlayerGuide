namespace TwentySix;

public class RobotTest
{
    public void Start()
    {
        var robot = new Robot();
        for (int i = 0; i < robot.Commands.Length; i++)
        {
            robot.Commands[i] = GetCommand();
        }
        
        robot.Run();
    }

    private RobotCommand? GetCommand()
    {
        return Console.ReadLine() switch
        {
            "on" => new OnCommand(),
            "off" => new OffCommand(),
            "north" => new NorthCommand(),
            "east" => new EastCommand(),
            "south" => new SouthCommand(),
            "west" => new WestCommand(),
            _ => null
        };
    }
}
public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    
    public void Run()
    {
        foreach (var command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y++;
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y--;
    }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X++;
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X--;
    }
}