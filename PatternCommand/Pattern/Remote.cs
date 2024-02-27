namespace PatternCommand.Pattern
{
    public class Remote
    {
        public readonly List<ICommand> Commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            Commands.Add(command);
            command.Execute();
        }
    }
}
