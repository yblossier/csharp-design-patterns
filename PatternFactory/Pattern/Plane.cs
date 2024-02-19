namespace PatternFactory.Pattern;

public class Plane : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered on the air";
    }
}