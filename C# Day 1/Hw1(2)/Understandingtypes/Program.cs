// see https://aka.ms/new-console-template for more information


Console.WriteLine($"min int is {int.MinValue}, and max int is {int.MaxValue}");
Console.WriteLine($"min sbyte is {sbyte.MinValue}, and max sbyte is {sbyte.MaxValue}");
Console.WriteLine($"min short is {short.MinValue}, and max short is {short.MaxValue}");
Console.WriteLine($"min ushory is {ushort.MinValue}, and max ushort is {ushort.MaxValue}");
Console.WriteLine($"min uint is {uint.MinValue}, and max uint is {uint.MaxValue}");
Console.WriteLine($"min ulong is {long.MinValue}, and max ulong is {ulong.MaxValue}");


Console.WriteLine("enter the number of centries:");
int centry = Int32.Parse(Console.ReadLine());
Console.WriteLine($"{centry} centires = {centry * 100} years = {centry * 100 * 365} days = {centry * 100 * 8760} hours = {centry * 100 * 8760 * 60} minutes= {centry * 100 * 8760 * 3600} seconds = 3155673600000 milliseconds = 3155673600000000 microseconds = 3155673600000000000 nanosecond");



