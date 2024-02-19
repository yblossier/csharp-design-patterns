using PatternAbstractFactory.Pattern;

Console.WriteLine("      C# Design Pattern - Abstract Factory");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var renault = new RenaultFactory().CreateCityCar();
var vw = new VolkswagenFactory().CreateCityCar();
var bmw = new BmwFactory().CreateCityCar();

Console.WriteLine("We ask three car brand to produce their best city car :");
Console.WriteLine($"- {renault}");
Console.WriteLine($"- {vw}");
Console.WriteLine($"- {bmw}");

Console.WriteLine();
Console.WriteLine("Now we follow the instruction to turn on the card :");
Console.WriteLine($"- Renault : {renault.TurnOn()}");
Console.WriteLine($"- Volkswagen : {vw.TurnOn()}");
Console.WriteLine($"- Bmw : {bmw.TurnOn()}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();
