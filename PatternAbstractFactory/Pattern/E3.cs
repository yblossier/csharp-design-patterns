namespace PatternAbstractFactory.Pattern;

public class E3 : ICar
{
    /// <inheritdoc />
    public int GetWheels()
    {
        return 4;
    }

    /// <inheritdoc />
    public int GetDoors()
    {
        return 5;
    }

    /// <inheritdoc />
    public string GetBrand()
    {
        return "BMW";
    }

    /// <inheritdoc />
    public int GetFuel()
    {
        return 0;
    }

    /// <inheritdoc />
    public string TurnOn()
    {
        return "Please look the camera to proceed to facial recognition";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{GetBrand()} {nameof(E3)} with {GetWheels()} wheels, {GetDoors()} doors and a fuel-tank of {GetFuel()} liters";
    }
}