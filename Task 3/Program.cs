using System;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();

        //  Calling Increase using ref  
        int value = 20;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        //  Calling GetFullName using out 
        demo.GetFullName(out string fullName);
        Console.WriteLine("Full Name: " + fullName);

        //  Calling SumAll using params 
        int total = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}
