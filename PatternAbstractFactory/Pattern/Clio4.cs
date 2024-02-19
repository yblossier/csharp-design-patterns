namespace PatternAbstractFactory.Pattern;

public class Clio4 : ICar
{
    /// <inheritdoc />
    public int GetWheels()
    {
        return 5;
    }

    /// <inheritdoc />
    public int GetDoors()
    {
        return 5;
    }

    /// <inheritdoc />
    public string GetBrand()
    {
        return "Renault";
    }

    /// <inheritdoc />
    public int GetFuel()
    {
        return 45;
    }

    /// <inheritdoc />
    public string TurnOn()
    {
        return "Press the 'Start' button";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{GetBrand()} {nameof(Clio4)} with {GetWheels()} wheels, {GetDoors()} doors and a fuel-tank of {GetFuel()} liters";
    }
}