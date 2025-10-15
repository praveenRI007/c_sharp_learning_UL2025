// This file demonstrates the concept: Interfaces in C#
namespace Topics.PropertiesStructsInterfaces
{
    // Interface defines a contract (methods/properties) without implementation
    public interface IAnimal
    {
        void Speak();
    }

    // Class implements the interface
    public class InterfaceDog : IAnimal
    {
        public void Speak()
        {
            System.Console.WriteLine("InterfaceDog barks.");
        }
    }

    public class InterfacesDemo
    {
        public void Demo()
        {
            IAnimal animal = new InterfaceDog(); // Polymorphism
            animal.Speak(); // Output: InterfaceDog barks.
        }
    }
}
