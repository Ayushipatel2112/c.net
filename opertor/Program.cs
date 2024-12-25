using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        //logical opration
        //and &&
        int x = 5; 
        Console.WriteLine(x > 6 && x < 10);

       // or ||
       int y = 5;
        Console.WriteLine(y > 3 || y < 10);
        Console.WriteLine(y > 3 || y < 4);
        Console.WriteLine(y > 6 || y < 7);
        Console.WriteLine(y > 6 || y < 4);

        // ! -> not
        int z = 2;
        Console.WriteLine(!( z > 3 || z < 1));
    }
}