using System;
namespace hello;
class Program
{
    public static void Main(String[] args)
    {
        int a = 10;
        int b = 20;
        int c;
        Console.WriteLine("enter your choice : +,-,*,/");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                c = a + b;
                Console.WriteLine("Addition: " + c);
                break;
            case "-":
                c = a - b;
                Console.WriteLine("Substraction: " + c);
                break;
            case "*":
                c = a * b;
                Console.WriteLine("Multiplication: " + c);
                break;
            case "/":
                c = a / b;
                Console.WriteLine("Division: " + c);
                break;
            default:
                Console.WriteLine("Wrong Input: ");
                break ;

        }
    }
}