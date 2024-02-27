namespace PatternDecorator.Pattern
{
    public class Car : ICar
    {
        /// <inheritdoc />
        public virtual string getName()
        {
            return "Simple car";
        }

        /// <inheritdoc />
        public virtual string getBrand()
        {
            return "SoCommon";
        }

        /// <inheritdoc />
        public virtual int getPrice()
        {
            return 10;
        }

        /// <inheritdoc />
        public virtual int getWeight()
        {
            return 1000;
        }
    }
}
