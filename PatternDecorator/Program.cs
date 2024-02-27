using PatternDecorator.Pattern;

Console.WriteLine("      C# Design Pattern - Decorator");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("We have the basic car in stock");
var simpleCar = new Car();
Console.WriteLine($"- Brand: {simpleCar.getBrand()}");
Console.WriteLine($"- Name: {simpleCar.getName()}");
Console.WriteLine($"- Price: {simpleCar.getPrice()}");
Console.WriteLine($"- Weight: {simpleCar.getWeight()}");
Console.WriteLine();

Console.WriteLine("We also have the same car with opened roof in stock");
var carWithOpenedRoof = new CarWithOpenedRoof(simpleCar);
Console.WriteLine($"- Brand: {carWithOpenedRoof.getBrand()}");
Console.WriteLine($"- Name: {carWithOpenedRoof.getName()}");
Console.WriteLine($"- Price: {carWithOpenedRoof.getPrice()}");
Console.WriteLine($"- Weight: {carWithOpenedRoof.getWeight()}");
Console.WriteLine();

Console.WriteLine("We also have the same car with auto-radio in stock");
var cardWithAutoRadio = new CarWithAutoRadio(simpleCar);
Console.WriteLine($"- Brand: {cardWithAutoRadio.getBrand()}");
Console.WriteLine($"- Name: {cardWithAutoRadio.getName()}");
Console.WriteLine($"- Price: {cardWithAutoRadio.getPrice()}");
Console.WriteLine($"- Weight: {cardWithAutoRadio.getWeight()}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();
