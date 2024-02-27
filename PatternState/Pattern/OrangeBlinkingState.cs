namespace PatternState.Pattern;

public class OrangeBlinkingState : IState
{
    public TrafficLight Light;

    public OrangeBlinkingState(TrafficLight light)
    {
        Light = light;
    }

    /// <inheritdoc />
    public void Handle()
    {
        Light.Color = "Orange blinking";
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "The state is light ORANGE BLINKING";
    }
}