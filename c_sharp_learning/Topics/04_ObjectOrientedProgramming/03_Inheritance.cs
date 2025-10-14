// This file demonstrates the concept: Inheritance in C#
namespace Topics.ObjectOrientedProgramming
{
    // 🔹 BASE CLASS (Parent)
    // The Animal class is a general class.
    // Other classes can INHERIT its members (fields, methods, etc.)
    public class Animal
    {
        // Method of the base class
        public void Speak()
        {
            System.Console.WriteLine("Animal speaks");
        }
    }

    // 🔹 DERIVED CLASS (Child)
    // Dog inherits from Animal using the ':' symbol.
    // This means Dog gets access to all public/protected members of Animal.
    public class Dog : Animal
    {
        // Dog has its own method
        public void Bark()
        {
            System.Console.WriteLine("Dog barks");
        }
    }

    // 🔹 Demonstration class
    public class InheritanceDemo
    {
        public void Demo()
        {
            // Create an instance of Dog (child class)
            Dog dog = new Dog();

            // The Dog class can use both:
            // 1️⃣ Methods it inherited from Animal
            dog.Speak(); // Output: Animal speaks

            // 2️⃣ Its own methods
            dog.Bark();  // Output: Dog barks
        }
    }

    // 🔹 Optional: Run the demo with a Main method
    public class Program
    {
        public static void Main()
        {
            InheritanceDemo demo = new InheritanceDemo();
            demo.Demo();
        }
    }
}
