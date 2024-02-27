namespace PatternDecorator.Pattern;

public class CarWithAutoRadio : CarWithOption
{
    public CarWithAutoRadio(ICar baseCar)
        : base(baseCar)
    { }

    /// <inheritdoc />
    public override string getName()
    {
        return $"{_base.getName()} with auto-radio";
    }

    /// <inheritdoc />
    public override int getPrice()
    {
        return base.getPrice() + 500;
    }

    /// <inheritdoc />
    public override int getWeight()
    {
        return base.getWeight() + 25;
    }
}