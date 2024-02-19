namespace PatternFactory.Pattern;

public class SpaceFactory
{
    public ITransport CreateTransport()
    {
        return new Rocket();
    }
}