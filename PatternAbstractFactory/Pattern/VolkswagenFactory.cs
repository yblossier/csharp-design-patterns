namespace PatternAbstractFactory.Pattern;

public class VolkswagenFactory : ICityCarFactory
{
    /// <inheritdoc />
    public ICar CreateCityCar()
    {
        return new Golf6();
    }
}