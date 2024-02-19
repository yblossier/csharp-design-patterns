namespace PatternFactory.Pattern;

public class AirFactory
{
    public ITransport CreateTransport()
    {
        return new Plane();
    }
}