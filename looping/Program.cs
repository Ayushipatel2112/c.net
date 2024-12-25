using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        /** while loop **/
        int a = 1;
        while (a <= 5)
        {
            Console.WriteLine("Hello World");
            a++;
        }

        /** Do While **/
        int b = 1;
        do
        {
            Console.WriteLine(b);
            b++;
        }
        while (b >= 5);

        /**  For Loop **/
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
        }

        /**  Nested Loop **/

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine();
        }

        /** Nested Loop **/

        int c = 1;
        for (int i = 1; i <=3 ; i++)
        {
            for (int j = 1; j <=3; j++)
            {
                Console.Write(c+" ");
                c--;
            }
            Console.WriteLine();
        }
    }
}