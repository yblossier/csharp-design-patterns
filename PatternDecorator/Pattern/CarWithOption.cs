namespace PatternDecorator.Pattern;

public class CarWithOption : Car
{
    protected ICar _base;
    public CarWithOption(ICar baseCar)
    {
        _base = baseCar;
    }
}