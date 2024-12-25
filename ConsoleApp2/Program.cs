using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        // type casting -- implicity
        int num = 9;
        double num1 = num;
        Console.WriteLine(num1);
        
        // -- explicity
        double num2 = 50.05;
        int num3 = (int)num2;
        Console.WriteLine(num3);
        Console.ReadLine();
    }
}