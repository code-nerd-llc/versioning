using System.Reflection;
// FIX #1
Console.WriteLine($"Version: {Assembly.GetExecutingAssembly().GetName().Version}");

// FIX #2
Console.WriteLine();