// This file demonstrates the concept: Difference between abstract classes and interfaces
namespace Topics.PropertiesStructsInterfaces
{
    // Abstract class: can have implementation and fields
    public abstract class AnimalBaseForInterfaceDemo
    {
        public abstract void Speak(); // Abstract method
        public void Eat() => System.Console.WriteLine("Animal eats."); // Concrete method
    }

    // Interface: only method/property signatures, no implementation
    public interface IVehicle
    {
        void Drive();
    }

    public class AbstractVsInterfaceDog : AnimalBaseForInterfaceDemo
    {
        public override void Speak() => System.Console.WriteLine("AbstractVsInterfaceDog barks.");
    }

    public class Car : IVehicle
    {
        public void Drive() => System.Console.WriteLine("Car drives.");
    }

    public class AbstractVsInterface
    {
        public void Demo()
        {
            AnimalBaseForInterfaceDemo animal = new AbstractVsInterfaceDog();
            animal.Speak(); // Output: AbstractVsInterfaceDog barks.
            animal.Eat();   // Output: Animal eats.

            IVehicle vehicle = new Car();
            vehicle.Drive(); // Output: Car drives.
        }
    }
}
