using System;
namespace hello;
class user
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your name: ");
        String username = Console.ReadLine();
        Console.WriteLine("your name is : " + username);
        
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your age is: " + age);
    }
}
