// This file demonstrates the concept: Difference between Types and Type Members
namespace Topics.EnumsTypeMembers
{
    // Type: class, struct, enum, interface, delegate
    public class PersonType
    {
        // Type members: fields, properties, methods, events, etc.
        public string Name; // Field (type member)
        public int Age { get; set; } // Property (type member)
        public void Greet() // Method (type member)
        {
            System.Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    public class TypesVsTypeMembers
    {
        public void Demo()
        {
            PersonType person = new PersonType { Name = "Alice", Age = 30 };
            person.Greet(); // Output: Hello, my name is Alice and I am 30 years old.
        }
    }
}
