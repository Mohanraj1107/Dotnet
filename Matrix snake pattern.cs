// See https://aka.ms/new-console-template for more information

using System;

internal class DisplayMessageApp
{
    static void Main()
    {
        Console.Write("Enter the size of matrix (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nSnake Pattern Output:");
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            Console.WriteLine(); 
        }
    }
}
