using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Create object using default constructor
        Player p1 = new Player();
        Console.WriteLine("Player 1 Details:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);
        Console.WriteLine();

        // Create object using parameterized constructor
        Player p2 = new Player("Rohan", 5, 100);
        Console.WriteLine("Player 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}
