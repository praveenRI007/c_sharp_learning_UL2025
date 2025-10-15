// This file demonstrates the concept: Difference between classes and structs
namespace Topics.PropertiesStructsInterfaces
{
    // Class: Reference type
    public class Person
    {
        public string Name { get; set; }
    }

    // Struct: Value type
    public struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ClassesVsStructs
    {
        public void Demo()
        {
            // Classes: reference type (shared reference)
            Person p1 = new Person { Name = "Alice" };
            Person p2 = p1;
            p2.Name = "Bob";
            System.Console.WriteLine($"p1.Name = {p1.Name}"); // p1.Name = Bob

            // Structs: value type (copied value)
            Coordinate c1 = new Coordinate { X = 1, Y = 2 };
            Coordinate c2 = c1;
            c2.X = 10;
            System.Console.WriteLine($"c1.X = {c1.X}, c2.X = {c2.X}"); // c1.X = 1, c2.X = 10
        }
    }
}
