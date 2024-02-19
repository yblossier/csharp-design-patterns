namespace PatternAdapter.Pattern
{
    public class IPhone : ILightningPhone
    {
        private bool _connected;

        /// <inheritdoc />
        public void Charge()
        {
            if (_connected)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("...");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Plug the lightning cable first");
            }
        }

        /// <inheritdoc />
        public void UseLightning()
        {
            _connected = true;
            Console.WriteLine("Lightning cable plugged");
        }
    }
}
