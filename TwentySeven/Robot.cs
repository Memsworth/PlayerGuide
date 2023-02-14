namespace TwentySeven;

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

    private IRobotCommand? GetCommand()
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
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    
    public void Run()
    {
        foreach (var command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
    public void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y++;
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y--;
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X++;
    }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X--;
    }
}