namespace PatternFactory.Pattern;

public class Rocket : ITransport
{
    /// <inheritdoc />
    public string Deliver()
    {
        return "Products are delivered on the space";
    }
}