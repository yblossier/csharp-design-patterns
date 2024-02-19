namespace PatternFactory.Pattern;

public class Train : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered by the rail";
    }
}