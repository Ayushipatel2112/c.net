using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        /** Print 1 t0 50 Odd Number & Even Number **/
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " :  Even Number");
            }
            else
            {
                Console.WriteLine(i + " :  Odd Number");
            }
        }

        /** Print 1 to 50 Odd Number **/
        for (int i = 1; i <= 50; i++)
        {
            if(i %2 != 0)
            {
                Console.WriteLine(i + " : Odd Number");
            }
        }

    /** Print 1 to 10 Prime number Or Not Prime Number **/

    int n = 11, a = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                a++;
            }
        }

        if (a == 2)
        {
            Console.WriteLine($"{n} is a Prime Number");
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }
    }
}