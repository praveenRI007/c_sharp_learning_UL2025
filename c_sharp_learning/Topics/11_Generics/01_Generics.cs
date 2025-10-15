// This file demonstrates the concept: Generics in C#
namespace Topics.Generics
{
    // Generic class: works with any type T
    public class Box<T>
    {
        public T Value { get; set; }
        public Box(T value) { Value = value; }
    }

    public class GenericsDemo
    {
        // Generic method: works with any type
        public void PrintItem<T>(T item)
        {
            System.Console.WriteLine($"Item: {item}");
        }

        public void Demo()
        {
            // Using generic class
            Box<int> intBox = new Box<int>(123);
            Box<string> strBox = new Box<string>("Hello");
            System.Console.WriteLine($"intBox: {intBox.Value}, strBox: {strBox.Value}");

            // Using generic method
            PrintItem(42);         // Output: Item: 42
            PrintItem("World");   // Output: Item: World
        }
    }
}
