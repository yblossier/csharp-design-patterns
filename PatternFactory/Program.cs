using PatternFactory.Pattern;

Console.WriteLine("      C# Design Pattern - Factory");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var deliveryPlanProductA = new []{ PlanDeliveryTypeEnum.Road, PlanDeliveryTypeEnum.Highway, PlanDeliveryTypeEnum.Sea, PlanDeliveryTypeEnum.Rail };
var deliveryPlanProductB = new []{ PlanDeliveryTypeEnum.Air, PlanDeliveryTypeEnum.Space };

Console.WriteLine("- Product A -");
foreach (var plan in deliveryPlanProductA)
{
    Console.WriteLine($"- {TransportFactory.CreateTransport(plan).Deliver()}");
}
Console.WriteLine(@"/!\ Products arrived at destination");

Console.WriteLine();
Console.WriteLine("- Product B -");
foreach (var plan in deliveryPlanProductB)
{
    Console.WriteLine($"- {TransportFactory.CreateTransport(plan).Deliver()}");
}
Console.WriteLine(@"/!\ Products arrived at destination");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();
