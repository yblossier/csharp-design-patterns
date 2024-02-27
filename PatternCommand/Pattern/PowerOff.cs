namespace PatternCommand.Pattern;

public class PowerOff : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Power OFF was executed");
    }
}