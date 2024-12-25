using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        // simple if
        int a = 10;
        if (a < 5)
        {
            Console.WriteLine("0 is greater than 5");
        }

        // if -else
        int b = 3;
        if (b > 5)
        {
            Console.WriteLine("10 is < 5");
        }
        else
        {
            Console.WriteLine("3 is < 5");
        }

        // if else if else
        int a1 = 2;
        if (a1 > 18)
        {
            Console.WriteLine("you are volting");
        }
        else if (a1 == 18)
        {
            Console.WriteLine("This year, you are start volting");
        }
        else 
        {
            Console.WriteLine("not able");
        }

        // sort method
        int c = 1;
        string result = (c > 5) ? "yes" : "no";
        Console.WriteLine(result);
    }
}