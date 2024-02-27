namespace PatternDecorator.Pattern;

public class CarWithOpenedRoof : CarWithOption
{
    public CarWithOpenedRoof(ICar baseCar)
        : base(baseCar)
    { }

    /// <inheritdoc />
    public override string getName()
    {
        return $"{_base.getName()} with opened roof";
    }

    /// <inheritdoc />
    public override int getPrice()
    {
        return base.getPrice() + 10000;
    }

    /// <inheritdoc />
    public override int getWeight()
    {
        return base.getWeight() - 200;
    }
}