using System;
using System.Linq;

internal class StoreSalesAnalysis
{
    static void Main()
    {
        Console.Write("Enter number of days in the month: ");
        int n = int.Parse(Console.ReadLine());

        int[] sales = new int[n];

        // Reading sales values
        Console.WriteLine("Enter sales for each day:");
        for (int i = 0; i < sales.Length; i++)
        {
            sales[i] = int.Parse(Console.ReadLine());
        }

        // Display original sales
        Console.WriteLine("\nOriginal Sales Data:");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.Write(sales[i] + " ");
        }
        Console.WriteLine();

        // Sorting
        Array.Sort(sales);
        Console.WriteLine("\nSorted Sales Data:");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.Write(sales[i] + " ");
        }
        Console.WriteLine();

        // Reverse (without built-in)
        Console.WriteLine("\nReverse Sales Data (without built-in):");
        for (int i = sales.Length - 1; i >= 0; i--)
        {
            Console.Write(sales[i] + " ");
        }
        Console.WriteLine();

        // Reverse with built-in
        Array.Reverse(sales);
        Console.WriteLine("\nReverse Sales Data (with built-in):");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.Write(sales[i] + " ");
        }
        Console.WriteLine();

        // Summary statistics
        int total = sales.Sum();
        int max = sales.Max();
        int min = sales.Min();

        Console.WriteLine($"\nTotal Sales: {total}");
        Console.WriteLine($"Highest Sales: {max}");
        Console.WriteLine($"Lowest Sales: {min}");

        // Searching
        Console.Write("\nEnter a sales value to search: ");
        int key = int.Parse(Console.ReadLine());

        int result = Array.BinarySearch(sales, key);
        if (result < 0)
        {
            Console.WriteLine($"Sales value {key} not found.");
        }
        else
        {
            Console.WriteLine($"Sales value {key} found at index {result}.");
        }

        // Backup sales data
        int[] backup = new int[n];
        Array.Copy(sales, backup, n);

        Console.WriteLine("\nBackup Data:");
        for (int i = 0; i < backup.Length; i++)
        {
            Console.Write(backup[i] + " ");
        }
        Console.WriteLine();

        // Comparing with another sales dataset
        Console.WriteLine("\nEnter another sales dataset to compare:");
        int[] newset = new int[n];

        for (int i = 0; i < n; i++)
        {
            newset[i] = int.Parse(Console.ReadLine());
        }

        bool compare = sales.SequenceEqual(newset);

        if (compare)
        {
            Console.WriteLine("\nBoth datasets are EQUAL.");
        }
        else
        {
            Console.WriteLine("\nBoth datasets are NOT EQUAL.");
        }

        Console.WriteLine("\n--- Program Completed ---");
    }
}
