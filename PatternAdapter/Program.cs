using PatternAdapter.Pattern;

Console.WriteLine("      C# Design Pattern - Adapter");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var iPhone = new IPhone();
var android = new Android();

Console.WriteLine("1- Recharging the iPhone with lightning cable");
RechargeLightningPhone(iPhone);
Console.WriteLine();

Console.WriteLine("2- Recharging the Android with USB-C cable");
RechargeUsbCPhone(android);
Console.WriteLine();

Console.WriteLine("2- Recharging the iPhone with USB-C cable");
RechargeUsbCPhone(new LightningToUsbCAdapter(iPhone));
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();

void RechargeUsbCPhone(IUsbCPhone phone)
{
    phone.UseUsbC();
    phone.Charge();
}

void RechargeLightningPhone(ILightningPhone phone)
{
    phone.UseLightning();
    phone.Charge();
}