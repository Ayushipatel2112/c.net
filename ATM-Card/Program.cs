using System;
namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        int acno;
        Console.Write("Account No: ");
        acno=Convert.ToInt32(Console.ReadLine());
        Console.Write("Balance: ");
        int balance = Convert.ToInt32(Console.ReadLine());

        // diposit
        Console.Write("Your Deposit: ");
        int x = Convert.ToInt32(Console.ReadLine());
        balance = balance + x;

        // withdraw
        Console.Write("Your Withdraw: ");
        int a = Convert.ToInt32(Console.ReadLine());
        balance = balance - a;

        // show all detail
        Console.Write("Account No: " + acno);
        Console.Write("Balance: " + balance);

        // fumction
        int x = 0;
        while(x!=5)
        {
            Console.WriteLine("1.Bank Statement");
            Console.WriteLine("2.Diposite");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.exit");

            Console.Write("Enter Your Choice: ");
            x = Convert.ToInt32(Console.ReadLine());

            string op = Console.ReadLine();
            switch(op)
            {
                case 1:
                    Console.Write("Account No: ");
                    acno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Balance: ");
                    int balance = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}