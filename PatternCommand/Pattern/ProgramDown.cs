namespace PatternCommand.Pattern;

public class ProgramDown : ICommand
{
    /// <inheritdoc />
    public void Execute()
    {
        Console.WriteLine("- Program DOWN was executed");
    }
}