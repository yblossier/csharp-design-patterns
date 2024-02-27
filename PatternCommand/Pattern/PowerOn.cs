namespace PatternCommand.Pattern;

public class PowerOn : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Power ON was executed");
    }
}