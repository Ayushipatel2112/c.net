using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        // Single Array for String
        string[] arr = { "Ayushi", "Misva", "Anisha", "Miral", "Tisha" };
        Console.WriteLine(arr[4]);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        // Single Array for int
        int[] number = { 5, 1, 6, 8, 9, 10 };
        Console.WriteLine(number.Sum());
        Console.WriteLine(number.Max());
        Console.WriteLine(number.Min());

        // 2d Array
        int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        arr2[1, 2] = 9;
        Console.WriteLine(arr2[1, 1]);

        // Nested Loop for 2d Array
        int[,] array = { { 1, 6, 8 }, { 4, 2, 3 } };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine(array[i, j]);
            }
        }

        //foreach loop for string
        string[] name = { "Ayushi", "Misva", "Tisha", "Ansiha" };
        foreach (string i in name)
        {
            Console.WriteLine(i);
        }

        //foreach loop for integer
        int[] num = { 1, 2, 3, 4, 5 };
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }
    }
}