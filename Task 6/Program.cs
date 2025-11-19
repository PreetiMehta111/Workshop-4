using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        int.TryParse(Console.ReadLine(), out int total);

        // Breakpoint 1

        double percentage = (double)marks / total * 100;

        // Breakpoint 2

        Console.WriteLine("Percentage: " + percentage);
    }
}
