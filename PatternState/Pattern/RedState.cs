namespace PatternState.Pattern;

public class RedState : IState
{
    public TrafficLight Light;

    public RedState(TrafficLight light)
    {
        Light = light;
    }

    /// <inheritdoc />
    public void Handle()
    {
        Light.Color = "Red";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "The state is light RED";
    }
}