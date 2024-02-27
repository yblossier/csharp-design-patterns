namespace PatternCommand.Pattern;

public class VolumeDown : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Volume DOWN was executed");
    }
}