namespace PatternAbstractFactory.Pattern;

public class RenaultFactory : ICityCarFactory
{
    /// <inheritdoc />
    public ICar CreateCityCar()
    {
        return new Clio4();
    }
}