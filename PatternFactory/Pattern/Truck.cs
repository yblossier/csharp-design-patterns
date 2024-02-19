namespace PatternFactory.Pattern;

public class Truck : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered by the highway";
    }
}