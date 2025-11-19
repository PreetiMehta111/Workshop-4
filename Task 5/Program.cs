using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (day == "friday" || day == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is : {dayType}");
        Console.WriteLine();


        // Creating the first book object
        Book book1 = new Book("C# Basics", "John Doe", 450.0);

        // Creating the second book object using 'with'
        Book book2 = book1 with { title = "Advanced C#", price = 650.0 };

        // Printing the first book details
        Console.WriteLine("First Book Details:");
        Console.WriteLine(book1);
        Console.WriteLine();

        // Deconstructing the second object
        var (title, author, price) = book2;

        Console.WriteLine("Second Book Details (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
