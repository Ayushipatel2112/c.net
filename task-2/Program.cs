namespace hello;
class Program
{
    public static void Main(string[] args)
    {
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < numbers.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < numbers.GetLength(1); j++) // Columns
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
