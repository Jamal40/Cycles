using System.Runtime.CompilerServices;

Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");
var array = new string[] { "Muhammed", "Ahmed", "Manar", "Nada" };

Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");
foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");
var listTask1 = File.ReadAllLinesAsync("NamesFromFile.txt");
var listTask2 = File.ReadAllLinesAsync("NamesFromFile.txt");
Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");

var list = await listTask1;
Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");
var list2 = await listTask2;
Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");


Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine($"{Line()} {Environment.CurrentManagedThreadId}");

static int Line([CallerLineNumber] int lineNumber = 0)
    => lineNumber;
