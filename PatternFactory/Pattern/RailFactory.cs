namespace PatternFactory.Pattern;

public class RailFactory
{
    public ITransport CreateTransport()
    {
        return new Train();
    }
}