using System;
namespace hello;
class Maths
{
    public static void Main(string[] args)
    {
        // Math -> max,min,sqrt,abs,round

        Console.WriteLine(Math.Max(3, 15));
        Console.WriteLine(Math.Min(3,15));
        Console.WriteLine(Math.Sqrt(25));
        Console.WriteLine(Math.Abs(-3.6));
        Console.WriteLine(Math.Round(2.4));
        Console.WriteLine(Math.Round(2.55));
    }
}