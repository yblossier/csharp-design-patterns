namespace PatternState.Pattern;

public class OrangeState : IState
{
    public TrafficLight Light;

    public OrangeState(TrafficLight light)
    {
        Light = light;
    }

    /// <inheritdoc />
    public void Handle()
    {
        Light.Color = "Orange";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "The state is light ORANGE";
    }
}