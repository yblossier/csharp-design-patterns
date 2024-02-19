namespace PatternFactory.Pattern
{
    public class RoadFactory
    {
        public ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
