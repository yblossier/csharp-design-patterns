namespace PatternFactory.Pattern;

public class Boat : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered by the sea";
    }
}