namespace PatternFactory.Pattern;

public interface ITransport
{
    /// <summary>
    /// Executes the delivery of products
    /// </summary>
    /// <returns>The delivery process</returns>
    string Deliver();
}