namespace PatternFactory.Pattern;

public class SeaFactory
{
    public ITransport CreateTransport()
    {
        return new Boat();
    }
}