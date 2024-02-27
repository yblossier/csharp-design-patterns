namespace PatternState.Pattern;

public class GreenState : IState
{
    public TrafficLight Light;

    public GreenState(TrafficLight light)
    {
        Light = light;
    }

    /// <inheritdoc />
    public void Handle()
    {
        Light.Color = "Green";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "The state is light GREEN";
    }
}