// See https://aka.ms/new-console-template for more information
using System;
internal class DisplayMessageApp
{
    static void Main()
    {
        Console.Write("Enter size of matrix (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];
        Console.WriteLine("Enter the matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int primarySum = 0;
        int secondarySum = 0;

        for (int i = 0; i < n; i++)
        {
            primarySum += mat[i, i];         
            secondarySum += mat[i, n - 1 - i];
        }
        int diff = Math.Abs(primarySum - secondarySum);
        Console.WriteLine("Primary Diagonal Sum = " + primarySum);
        Console.WriteLine("Secondary Diagonal Sum = " + secondarySum);
        Console.WriteLine("Absolute Difference = " + diff);
    }
}
