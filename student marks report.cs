using System;
using System.Linq;

internal class StudentMarksReport
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        Console.WriteLine("\nEnter marks of each student:");
        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nOriginal Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();
        Array.Sort(marks);
        Console.WriteLine("\nSorted Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("\nReverse Marks (Manual):");
        for (int i = marks.Length - 1; i >= 0; i--)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();
        Array.Reverse(marks);
        Console.WriteLine("\nReverse Marks (Built-in):");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();
        int total = marks.Sum();
        int max = marks.Max();
        int min = marks.Min();
        Console.WriteLine($"\nTotal Marks: {total}");
        Console.WriteLine($"Highest Mark: {max}");
        Console.WriteLine($"Lowest Mark: {min}");
        Console.Write("\nEnter a mark to search: ");
        int key = int.Parse(Console.ReadLine());

        int result = Array.BinarySearch(marks, key);
        if (result < 0)
        {
            Console.WriteLine($"Mark {key} was NOT found.");
        }
        else
        {
            Console.WriteLine($"Mark {key} found at index {result}.");
        }
        int[] backup = new int[n];
        Array.Copy(marks, backup, marks.Length);

        Console.WriteLine("\nBackup Data:");
        for (int i = 0; i < backup.Length; i++)
        {
            Console.Write(backup[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("\nEnter another set of marks for comparison:");
        int[] newset = new int[n];

        for (int i = 0; i < n; i++)
        {
            newset[i] = int.Parse(Console.ReadLine());
        }

        bool equal = marks.SequenceEqual(newset);

        if (equal)
        {
            Console.WriteLine("\nBoth sets of marks are IDENTICAL.");
        }
        else
        {
            Console.WriteLine("\nBoth sets of marks are DIFFERENT.");
        }

        Console.WriteLine("\n--- Report Generation Complete ---");
    }
}
