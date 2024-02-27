namespace PatternCommand.Pattern;

public class VolumeUp : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Volume UP was executed");
    }
}