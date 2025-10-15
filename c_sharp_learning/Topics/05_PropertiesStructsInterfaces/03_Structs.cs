// This file demonstrates the concept: Structs in C#
namespace Topics.PropertiesStructsInterfaces
{
    // Structs are value types and are used for small data structures.
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class StructsDemo
    {
        public void Demo()
        {
            // Structs are allocated on the stack and copied by value
            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = p1; // p2 is a copy of p1
            p2.X = 10;
            System.Console.WriteLine($"p1.X = {p1.X}, p2.X = {p2.X}"); // p1.X = 1, p2.X = 10
        }
    }
}
