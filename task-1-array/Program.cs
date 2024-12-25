using System;
namespace array;
class Program
{
    public static void Main(string[] args)
    {
        // addition in function using array
        //int[] number = { 1, 2, 3, 4 };
        //int sum = number.Sum();
        //Console.WriteLine(sum);

        // loop using addition in array
        int[] arr = { 5, 6, 7, 8, 9 };
        int sum1 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum1 += arr[i];
        }
        Console.WriteLine(sum1);

        // user input array
        
        Console.WriteLine("Enter the Array: ");
        int[] a = new int[5];
        for(int i = 0;i < 5;i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Array is : " + a[i] + " ");
        }
    }
}