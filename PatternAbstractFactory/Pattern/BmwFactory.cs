namespace PatternAbstractFactory.Pattern;

public class BmwFactory : ICityCarFactory
{
    /// <inheritdoc />
    public ICar CreateCityCar()
    {
        return new E3();
    }
}