// This file demonstrates the concept: Polymorphism
namespace Topics.ObjectOrientedProgramming
{
    // 🔹 BASE CLASS
    public class PolyAnimal
    {
        // The 'virtual' keyword allows derived classes to OVERRIDE this method.
        public virtual void Speak()
        {
            System.Console.WriteLine("Animal speaks");
        }
    }

    // 🔹 DERIVED CLASS
    // 'override' replaces the base class method behavior at runtime.
    public class Cat : PolyAnimal
    {
        public override void Speak()
        {
            System.Console.WriteLine("Cat meows");
        }
    }

    // 🔹 DEMONSTRATION CLASS
    public class PolymorphismDemo
    {
        public void Demo()
        {
            // The reference type is PolyAnimal (base class)
            // The actual object type is Cat (derived class)
            PolyAnimal animal = new Cat();

            // Because 'Speak()' is virtual and overridden in Cat,
            // the method call is resolved at RUNTIME based on the actual object.
            // Output: "Cat meows"
            animal.Speak();
        }
    }

    // 🔹 Optional entry point
    public class Program2
    {
        public static void Main2()
        {
            PolymorphismDemo demo = new PolymorphismDemo();
            demo.Demo();
        }
    }
}
