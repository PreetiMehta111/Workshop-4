// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first student object
        Student s1 = new Student();
        s1.name = "Ramesh";
        s1.age = 20;
        s1.course = "BSc Computing";

        // Create second student object
        Student s2 = new Student();
        s2.name = "Sita";
        s2.age = 21;
        s2.course = "BIT";

        // Display first object details
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Course: " + s1.course);

        // Display second object details
        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Course: " + s2.course);

        // Print static field
        Console.WriteLine("\nCollege Name: " + Student.collegeName);
    }
}