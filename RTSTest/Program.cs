
Console.WriteLine("RTS Take Home Test Console Application, by Patrick Best");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Running AboveBelow with sample input of [1, 5, 2, 1, 10] (unsorted Array) and 6 (comparison value)");

var response = AboveBelow.aboveBelow(new List<int>() {1, 5, 2, 1, 10}, 6);

Console.WriteLine($"Above: {response.Above}, Below {response.Below}");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Running AboveBelowOptimized with sample input of [1, 5, 2, 1, 10] (unsorted Array) and 6 (comparison value)");

var oprtimizedResponse = AboveBelow.aboveBelowOptimized(new List<int>() {1, 5, 2, 1, 10}, 6);

Console.WriteLine($"Above: {oprtimizedResponse.Above}, Below {oprtimizedResponse.Below}");

Console.WriteLine("--------------------------------------------");


Console.WriteLine("Running StringRotation with sample input of `MyString` (input string) and 2 (rotation amount)");

var stringResponse = StringRotation.stringRotation("MyString", 2);

Console.WriteLine($"Result: {stringResponse}");

Console.WriteLine("--------------------------------------------");