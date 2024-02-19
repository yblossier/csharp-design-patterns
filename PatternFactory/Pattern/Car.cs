namespace PatternFactory.Pattern;

public class Car : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered by the road";
    }
}