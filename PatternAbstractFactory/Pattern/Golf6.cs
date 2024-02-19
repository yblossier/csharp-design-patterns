namespace PatternAbstractFactory.Pattern;

public class Golf6 : ICar
{
    /// <inheritdoc />
    public int GetWheels()
    {
        return 5;
    }

    /// <inheritdoc />
    public int GetDoors()
    {
        return 3;
    }

    /// <inheritdoc />
    public string GetBrand()
    {
        return "Volkswagen";
    }

    /// <inheritdoc />
    public int GetFuel()
    {
        return 50;
    }

    /// <inheritdoc />
    public string TurnOn()
    {
        return "Insert and turn the key";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{GetBrand()} {nameof(Golf6)} with {GetWheels()} wheels, {GetDoors()} doors and a fuel-tank of {GetFuel()} liters";
    }
}