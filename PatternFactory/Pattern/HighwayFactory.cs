namespace PatternFactory.Pattern;

public class HighwayFactory
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}