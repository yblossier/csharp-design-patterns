using PatternState.Pattern;

Console.WriteLine("      C# Design Pattern - State");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var light = new TrafficLight();
Console.WriteLine("The traffic light is in maintenance");
light.SetInMaintenance();
Console.WriteLine();
Console.WriteLine(@"/!\ Check the state of the traffic light");
Console.WriteLine(light);
Console.WriteLine();
Console.WriteLine("We open the traffic");
light.OpenTraffic();
Console.WriteLine();
Console.WriteLine(@"/!\ Check the state of the traffic light");
Console.WriteLine(light);
Console.WriteLine();
Console.WriteLine("We close the traffic");
light.CloseTraffic();
Console.WriteLine();
Console.WriteLine(@"/!\ Check the state of the traffic light");
Console.WriteLine(light);
    
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();