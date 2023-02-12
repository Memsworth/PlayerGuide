namespace TwentyFour;

public class DoorTest
{
    public void Start()
    {
        var doorTest = new Door(1234);
        var userInterface = new DoorInterface();

        while (true)
        {
            userInterface.DoorStatus(doorTest);
            Console.Write("What you wanna do: ");
            var choice = Console.ReadLine() ?? throw new ArgumentNullException();
            
            switch (choice.ToLower())
            {
                case "exit":
                    return;
                case "unlock":
                case "lock": 
                case "open": 
                case "close":
                    userInterface.ChangeDoorStatus(choice, doorTest);
                    break;
                case "change passcode":
                    userInterface.ChangePass(doorTest);
                    break;
            }
        }
    }

}
public class Door
{
    public int PassCode { get; private set; }
    
    public State DoorState { get; private set; }

    public Door(int passCode)
    {
        PassCode = passCode;
        DoorState = State.Locked;
    }

    public void ChangePassword(int num)
    {
        PassCode = num;
    }

    public void StateChange(State state)
    {
        DoorState = state;
    }
}

public class DoorInterface
{
    public void DoorStatus(Door door)
    {
        Console.WriteLine($"The door is currently {door.DoorState.ToString().ToLower()}");
    }

    public void ChangePass(Door door)
    {
        var input = GetPassCode();
        var newPass = Helper.GetValidNumberInRange(1000, 9999, "Enter the new passcode");
        
        if (door.PassCode == input && door.DoorState != State.Locked)
            door.ChangePassword(newPass);
    }

    public void ChangeDoorStatus(string input, Door door)
    {
        switch (input)
        {
            case "unlock" when door.DoorState == State.Locked:
                if (GetPassCode() == door.PassCode)
                    door.StateChange(State.Closed);
                break;
            case "lock" when door.DoorState == State.Closed:
                door.StateChange(State.Locked);
                break;
            case "open" when door.DoorState == State.Closed:
                door.StateChange(State.Open);
                break;
            case "close" when  door.DoorState == State.Open:
                door.StateChange(State.Closed);
                break;
        }
    }

    private int GetPassCode() => Helper.GetValidNumberInRange(1000, 9999, "Enter door's passcode (4 digits)");
}

public enum State
{
    Locked, Closed, Open
}