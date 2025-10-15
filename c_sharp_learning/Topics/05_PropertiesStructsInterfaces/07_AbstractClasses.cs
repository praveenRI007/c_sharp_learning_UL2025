// This file demonstrates the concept: Abstract classes in C#
namespace Topics.PropertiesStructsInterfaces
{
    // Abstract class cannot be instantiated directly. It can contain abstract and non-abstract members.
    public abstract class Animal
    {
        // Abstract method (must be implemented by derived classes)
        public abstract void Speak();

        // Non-abstract method
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class must implement abstract members
    public class AbstractDog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("AbstractDog barks.");
        }
    }

    public class AbstractClassesDemo
    {
        public void Demo()
        {
            Animal animal = new AbstractDog(); // Polymorphism
            animal.Speak(); // Output: AbstractDog barks.
            animal.Eat();   // Output: Animal is eating.
        }
    }
}
