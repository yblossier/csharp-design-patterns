namespace PatternAdapter.Pattern;

public class Android : IUsbCPhone
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
            Console.WriteLine("Plug the USB-C cable first");
        }
    }

    /// <inheritdoc />
    public void UseUsbC()
    {
        _connected = true;
        Console.WriteLine("USB-C cable plugged");
    }
}