using System;
namespace hello;
class type_conversion
{
    public static void Main(string[] args)
    {
        int num = 65;
        double db = 10.5;
        string sr = "ayushi";
        bool bl = false;
        char c = 'a';

        Console.WriteLine(Convert.ToString(db)); // double to string
        Console.WriteLine(Convert.ToInt32(c)); // char to int 
        Console.WriteLine(Convert.ToString(num)); // int to string
        Console.WriteLine(Convert.ToInt32(db)); // double to int 
        Console.ReadLine();
    }
}