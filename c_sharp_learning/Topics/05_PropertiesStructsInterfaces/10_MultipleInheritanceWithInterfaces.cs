// This file demonstrates the concept: Multiple class inheritance using interfaces
namespace Topics.PropertiesStructsInterfaces
{
    // Interfaces allow multiple inheritance of behavior
    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    // Class can implement multiple interfaces
    public class Duck : IFlyable, ISwimmable
    {
        public void Fly() => System.Console.WriteLine("Duck flies.");
        public void Swim() => System.Console.WriteLine("Duck swims.");
    }

    public class MultipleInheritanceWithInterfaces
    {
        public void Demo()
        {
            Duck duck = new Duck();
            duck.Fly();  // Output: Duck flies.
            duck.Swim(); // Output: Duck swims.
        }
    }
}
