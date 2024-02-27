namespace PatternCommand.Pattern;

public class ProgramUp : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Program UP was executed");
    }
}