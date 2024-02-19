namespace PatternFactory.Pattern
{
    public static class TransportFactory
    {
        public static ITransport CreateTransport(PlanDeliveryTypeEnum deliveryType)
        {
            switch (deliveryType)
            {
                case PlanDeliveryTypeEnum.Road: return new RoadFactory().CreateTransport();
                case PlanDeliveryTypeEnum.Highway: return new HighwayFactory().CreateTransport();
                case PlanDeliveryTypeEnum.Rail: return new RailFactory().CreateTransport();
                case PlanDeliveryTypeEnum.Sea: return new SeaFactory().CreateTransport();
                case PlanDeliveryTypeEnum.Air: return new AirFactory().CreateTransport();
                case PlanDeliveryTypeEnum.Space: return new SpaceFactory().CreateTransport();
                default: throw new Exception("We can't deliver the products");
            }
        }
    }
}
