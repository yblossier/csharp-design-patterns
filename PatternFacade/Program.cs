// See https://aka.ms/new-console-template for more information

using PatternFacade.Pattern;

Console.WriteLine("      C# Design Pattern - Facade");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var samples = Directory.GetFiles("./samples");
foreach(var sample in samples)
{
    var mimeType = new ImageConverter().GetMimeType(sample);
    Console.WriteLine($"- MimeType for ${sample} is {mimeType}");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press a key to end the program");
Console.ReadKey();
