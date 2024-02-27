using PatternSingleton.Pattern;

Console.WriteLine("      C# Design Pattern - Singleton");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("- Ask to get the unique instance named '1st instance' - 1st time -");
var instance = UniqueInstance.Instance("1st instance");
var name = instance.GetName();
Console.WriteLine($"The name of the instance is {name}");

Console.WriteLine("- Ask to get another unique instance named '2nd instance' - 2nd time -");
var instance2 = UniqueInstance.Instance("2nd instance");
var name2 = instance2.GetName();
Console.WriteLine($"The name of the instance is {name2}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();